using UnityEngine;
using System.Collections;

public static class Functions
{
	/// Random XYZ
	/// 912
	static class rndXYZ
	{
		public static float X;
		public static float Y;
		public static float Z;
		public static int I;

		public static void Randomize(int i)
		{
			I = i;
			Y = rnd;
			X = (200f + 500f * Y) * Mathf.Pow (5, I); 
			Z = X * Y;
		}
	}

	public static float rnd
	{
		get
		{
			return Round2(UnityEngine.Random.Range(0.05f,1f));
		}
	}

	/// <summary>
	/// Перерасчёт азартных игр
	/// </summary>
	public static void ReCalcGames()
	{
		for (int i=0; i < 5; i++)
		{
			rndXYZ.Randomize(i);
			Values.R1[i] = (int) rndXYZ.X;
			Values.R2[i] = (int)(rndXYZ.X * ( 2 - rndXYZ.Y));
			Values.R3[i] = (int)(rndXYZ.Y * 100);
		}
	}

	/// <summary>
	/// Распродать акции
	/// </summary>
	/// <value>The sell stock.</value>
	public static int SellStock
	{
		get
		{
			int X = (int) (Values.A[1] * rnd);
			Values.A[0] += X;
			Values.A[1] = 0;
			for (int i=0; i<5; i++)
				Values.F[i] = 0;

			return X;
		}
	}

	/// <summary>
	/// Распродать имущество
	/// </summary>
	/// <value>The sell stock.</value>
	public static int SellFlat
	{
		get
		{
			int X = (int) (Values.A[2] * rnd);
			Values.A[0] += X;
			Values.A[2] = 0;
			for (int i=0; i<5; i++)
			{
				Values.C[i] = 0;
				Values.E[i] = 0;
				Values.D[i] = 0;
			}
			return X;
		}
	}

	/// <summary>
	/// Посадили
	/// 1106
	/// </summary>
	public static int Jail
	{
		get
		{
			int X = (int)(0 - Values.A [0] / 500) + 1;
			if (X > 15)
				return X; // казнили

			Values.N2 += X;
			Values.N += X;

			for (int i=0; i<5; i++)
				Values.B [i] = 0;
			Values.B [0] = 1;

			Values.K2 -= X;
			Values.S6 -= X;

			Values.A [0] = (int)(1000 + 500 * rnd);
			Values.A [3] = 0;
			Values.A [4] = 0;

			return X;
		}
	}

	/// <summary>
	/// Разбились
	/// </summary>
	public static void Crash(int pNo, int pAcc)
	{
		Values.A[0] = Values.A[0] - pAcc + Values.G3[pNo] * Values.G[pNo];
		
		Values.C[pNo] = 0;
		Values.G[pNo] = 0;
		Values.G1[pNo] = 0;
		Values.G2[pNo] = 0;
		Values.G3[pNo] = 0;
	}

	/// <summary>
	/// Перерасчёт стоимости акций
	/// </summary>
	public static void ReCalcStock()
	{
		for (int i=0; i < 5; i++)
		{
			Values.F1[i] = (int)(100f * rnd);
			Values.F2[i] = 20f * rnd;
			Values.J[i] =-1;
		}
	}

	/// <summary>
	/// Несчастный случай на бирже
	/// 416
	/// </summary>
	public static bool Accident (out int Damage, out int acc)
	{
		acc = (int)(rnd * 10f);
		Damage = 0;

		if (acc >= 5)
			return false;

		if (Values.D[acc] == 1)
			return false;

		if (acc == 4) // Все акции
		{
			int X = 0;
			for (int a = 0; a<5; a++)
			{
				X += Values.F[a] * Values.F1[a];
				Values.F[a] = 0;
			}

			Damage = X;

			if (X == 0)
				return false;

		}
		else // Всё прочее
			Damage = (int)(Values.A[0] * rnd);

		return true;
	}

	/// <summary>
	/// Округление до 2х знаков после запятой
	/// </summary>
	/// <param name="pVal">P value.</param>
	public static float Round2(float pVal)
	{
		return Mathf.Round (pVal * 100f) / 100f;
	}

	/// <summary>
	/// Подсчёт финансового состояния
	/// </summary>
	public static int CalcFinance()
	{
		Values.A [1] = 0;
		Values.A [2] = 0;
		Values.A [3] = 0;
		Values.A [4] = 0;

		for (int i=0; i<5; i++)
		{
			Values.A[1] += Values.F[i] * Values.F1[i];
			Values.A[2] += (int)(Values.C[i] * Values.C3[i] + Values.E[i] * Values.E3[i]);
			Values.A[3] += (int)(0f + Values.E[i] * Values.E1[i] + Values.F[i] * Values.F2[i] * 0.5f);
			Values.A[4] += (int)(0f + Values.D[i] * Values.D1[i] + Values.C[i] * Values.C2[i] * 0.45f + Values.G[i] * Values.G3[i] * 0.5f);
		}

		return Values.A [0] + Values.A1 + Values.A [1] + Values.A [2] + Values.A [3] - Values.A [4];
	}

	/// <summary>
	/// Ежегодное движение
	/// </summary>
	public static void CalcNY()
	{
		Values.A1 += (int)(0.2f * Values.A1 * Values.S);
		Values.A[0]  = Values.A[0] + Values.A[3] - Values.A[4];
	}

	/// <summary>
	/// Штраф
	/// </summary>
	public static int Penalty
	{
		get
		{
			int Y = (int)(rnd * Values.A[0] + 1000);
			if (Y<0)
				Y = -Y;
			Values.A[0] -= Y;
			return Y;
		}
	}

	/// <summary>
	/// Пересчитать цены на недвижимость
	/// </summary>
	public static void RecalcRealtyPrice()
	{
		for (int i=0; i<5; i++)
		{
			rndXYZ.Randomize(i);
			Values.C3[i] = (int) rndXYZ.X; // Цена покупки
			Values.C2[i] = (int) rndXYZ.Z; // Цена продажи
		}
	}

	/// <summary>
	/// Перерасчитать бизнес
	/// 264
	/// </summary>
	public static void RecalcBusiness()
	{
		for (int i=0; i<5; i++)
		{
			rndXYZ.Randomize(i);
			Values.E3[i] = (int) rndXYZ.X;
			Values.E2[i] = (int) rndXYZ.Z;
			Values.E1[i] = (int) (rndXYZ.Z*(rndXYZ.Y-0.5f));
		}
	}

	/// <summary>
	/// Страховку перерасчитываем
	/// 1310
	/// </summary>
	public static void ReCalcStr()
	{
		for (int i=0; i<5; i++)
		{
			Values.G1[i] --;
			if (Values.G1[i] <=0)
			{
				Values.G[i] = 0;
				Values.G1[i] = 0;
				Values.G2[i] = 0;
				Values.G3[i] = 0;
			}
		}
	}

	/// <summary>
	/// Удержать кредит
	/// </summary>
	public static int Kred
	{
		get
		{
			if (Values.K4 == 0)
				return 0;

			Values.K2 --;
			if (Values.K2 > 0)
				return 0;

			int X = (int) (Values.K1 + Values.K1 * Values.K3);
			Values.A[0] -= X;
			Values.K4 = 0;

			return X;
		}
	}

	/// <summary>
	/// Начислить ссуду
	/// </summary>
	public static int Ssud
	{
		get
		{
			if (Values.S4 == 0)
				return 0;

			Values.S6 --;

			if (Values.S6 > 0)
				return 0;

			Values.S4 = 0;

			if (Values.K5 > 0 && Values.S5 == 0)
				return -1;

			int X = (int)(Values.S1 + Values.S1 * Values.S2);
			Values.A[0] += X;
			return X;
		}
	}

	/// <summary>
	/// Перерасчёт наёма персонала
	/// </summary>
	public static void RecalcPersonel()
	{
		for (int i=0; i<5; i++)
		{
			rndXYZ.Randomize(i);
			Values.D1[i] = (int) (4500f * rndXYZ.Y + 2000f * (i+1));
			// Values.D3[i] = 0-Values.D1[i] * 2; Цена наёма нулевая.
		}
	}

	/// <summary>
	/// пересчитать общественное состояние
	/// 644
	/// </summary>
	public static int RecalcStat()
	{
		int X = 0;
		float Y = 0;
		for (int i=0; i<5; i++)
		{
			rndXYZ.Randomize(i);
			Values.B1[i] = (int)rndXYZ.X;
			if (Values.B[i] == 1)
				X = i + 1;
		}

		for (int i=0; i<5; i++)
		{
			Y += 0.5f * Values.C[i] + 2f * Values.D[i] + 0.5f * Values.E[i];
		}

		Values.B2[X] = Round2(Y / (5f * X));
		if (Values.B2[X] > 1f)
			Values.B2[X] = 1f;

		return X;
	}

	/// <summary>
	/// Проводятся ли в этом году выборы
	/// 628
	/// </summary>
	public static bool VybYear
	{
		get
		{
			return Values.N % 2 == 0; // каждые 2 года
		}
	}

	/// <summary>
	/// Состояние массива
	/// </summary>
	public static CategoryState ArrStat(int[] pArr)
	{
		int used = 0;
		int total = pArr.Length;
		for (int i=0; i<total; i++)
		{
			if (pArr [i] > 0)
				used++;
		}
		if (used == 0)
			return CategoryState.BUYONLY;
		else if (total == used)
			return CategoryState.SELLONLY;
		else 
			return CategoryState.BOTH;
	}

	/// <summary>
	/// Закрыть сделку по позиции
	/// 248-252
	/// </summary>
	/// <param name="pFlags">Флаги владения</param>
	/// <param name="pPriceBuy">Цена покупки</param>
	/// <param name="pPriceSell">Цена продажи</param>
	/// <param name="pNo">Номер позиции</param>
	/// <param name="pFlag">Флаг (1) покупка / (-1) продажа</param>
	public static void CloseDeal(int[] pFlags, int[] pPriceBuy, int[] pPriceSell, int pNo, int pFlag)
	{
		int price = pPriceSell [pNo] * pFlags [pNo] -  pPriceBuy[pNo] * (1 - pFlags [pNo]); 
		Values.A[0] += price;
		pFlags [pNo] += pFlag;
	}

	/// <summary>
	/// Уволить / нанять персонал
	/// </summary>
	public static void CloseDeal4(int[] pFlags, int[] pPriceBuy, int[] pPriceSell, int pNo, int pFlag)
	{
		int price = (int) (pPriceBuy[pNo] * pFlags [pNo] * 0.2f);
		Values.A[0] -= price;
		pFlags [pNo] += pFlag;
	}
#region Bank operations
	/// <summary>
	/// Банк обанкротился. Часть средств вернулась наличными.
	/// 514
	/// </summary>
	/// <value>The bankrot.</value>
	public static int Bankrot
	{
		get
		{
			if (UnityEngine.Random.value >= 0.97f)
			{
				int val = (int)(Values.A1 * 0.05f);
				Values.A[0] += val;
				Values.A1 = 0;
				return val;
			}
			return -1;
		}
	}

	/// <summary>
	/// Снять со счёта
	/// 554
	/// </summary>
	public static void BankGet(int pVal)
	{
		Values.A1 -= pVal;
		Values.A [0] += (int)(0.95f * pVal);
	}

	/// <summary>
	/// Положить на счёт
	/// 578
	/// </summary>
	public static void BankSet(int pVal)
	{
		Values.A1 += (int)(0.95f * pVal);
		Values.A [0] -= pVal;
	}

#endregion
}
