using UnityEngine;
using System.Collections;

public class GamePlay : MonoBehaviour 
{
	void Start()
	{
		StartGame ();
	}

	static int h = 0;
//	static int m = 0;

	public static void StartGame()
	{
		Values.Init ();

		TextWriter.Clear ();
		TextWriter.ShowMsg (Language.gettime);
		Controller.GetStr (timeGotten, true);

		//ShowMainMenu (true);
	}

#region Settings
	static void timeGotten(string pStr)
	{
		string[] strs = pStr.Split ('.');
		if (strs.Length > 2)
		{
			TextWriter.ShowMsg (Language.retry);
			Controller.GetStr (timeGotten, true);
		}
		else if (strs.Length > 1)
			GetYear ();
		else if (strs.Length > 0)
		{
			if (h > 0)
				GetYear ();
			else
			{
				h = 1;
				TextWriter.ShowMsg ("??");
				Controller.GetStr (timeGotten, true);
			}
		}
	}

	static void GetYear(bool pRetry = false)
	{
		if (pRetry)
			TextWriter.ShowMsg (Language.retry);
		else
			TextWriter.ShowMsg (Language.getyear);
		Controller.GetStr (yearGotten, true);
	}

	static void yearGotten(string pVAl)
	{
		int Y  = 0;
		if (int.TryParse (pVAl, out Y))
		{
			Values.M = Y;
			GetHard();
		}
		else
			GetYear(true);
	}

	static void GetHard(bool pRetry = false)
	{
		if (pRetry)
			TextWriter.ShowMsg (Language.retry);
		else
			TextWriter.ShowMsg (Language.getlev);
		Controller.GetStr (HardGotten, true);
	}

	static void HardGotten(string pVAl)
	{
		int Y = 0;
		if (int.TryParse (pVAl, out Y))
		{
			Values.K5 = Y;
			SayHello ();
		}
		else
			GetHard(true);
	}
#endregion Settings
#region Hello
	static void SayHello()
	{
		TextWriter.Clear ();
		TextWriter.ShowMsg (Language.hello);
		TextWriter.ShowMsg (Language.hello2);
		TextWriter.ShowMsg ("\n");
		TextWriter.ShowMsg (Language.canbe, 0.5f);
		ShowHaveTxt(Values.C, Language.VBS, -1, Language.have);
		Controller.GetStr (PayFor, true);
	}

	static void PayFor(string pVal)
	{
		TextWriter.Clear ();
		ShowHaveTxt(Values.E, Language.VCS, -1, Language.payfor);
		ShowHaveTxt(Values.D, Language.VDS, -1, Language.have);
		TextWriter.ShowMsg (Language.bill2, 0.5f);
		TextWriter.ShowMsg (Language.age);
		Controller.GetStr (AgeGotten, true);
	}

	static void AgeGotten(string pVAl)
	{
		int Y = 0;
		if (int.TryParse (pVAl, out Y))
		{
			if (Y > 60)
			{
				TextWriter.ShowMsg (Language.mummy);
				Retry();
			}
			else if (Y < 18)
			{
				TextWriter.ShowMsg (Language.young);
				Retry();
			}
			else
			{
				Values.N2 = Y;
				TextWriter.ShowMsg (Language.cash);
				Controller.GetStr (CashGotten,true);
			}
		}
		else
		{
			TextWriter.ShowMsg (Language.retry);
			Controller.GetStr (AgeGotten, true);
		}
	}

	static void CashGotten(string pVAl)
	{
		int Y = 0;
		if (int.TryParse (pVAl, out Y))
		{
			TextWriter.Clear();
			if (Y > Values.MaxStartCash)
			{
				TextWriter.ShowMsg (Language.toomuch);
				Y = Values.MaxStartCash;
			}
			Values.A[0] = Y;
			ShowMainMenu(false);
		}
		else
		{
			TextWriter.ShowMsg (Language.cash);
			Controller.GetStr (CashGotten,true);
		}
	}

#endregion Hello
#region MainMenu
	static void ShowMainMenu(bool clear = true)
	{
		if (clear)
			TextWriter.Clear ();
		ShowNal ();
		TextWriter.ShowMsg ("\n");
		TextWriter.ShowMsg (Language.MENU);
		Controller.GetStr (NavMenu1,true);
	}

	static void NavMenu1(string pVal)
	{
		NavMenu2 (pVal, true);
	}

	static int curMenuFlag;
	static void NavMenu2(string pVal, bool isFirst = true)
	{
		int i = 0;
		if (int.TryParse(pVal, out i))
		{
			curMenuFlag = i;
			switch (pVal)
			{
				case "1":
					ShowStat();
				break;
				case "2":
					ShowObStat(isFirst);
				break;
				case "3":
					ShowFlat(isFirst);
				break;
				case "4":
					ShowPersonel(isFirst);
				break;
				case "5":
					ShowBusiness(isFirst);
				break;
				case "6":
					ShowStock(isFirst);
				break;
				case "7":
					ShowBank(isFirst);
				break;
				case "8":
					Games(isFirst);
				break;
				default:
					ShowMainMenu(true);
				break;
			}
		}
		else
			ShowMainMenu(true);
	}

	static void BackToMenu(string pVal)
	{
		ShowMainMenu (true);
	}

	static void BackToMenu()
	{
		ShowMainMenu (true);
	}
#endregion MainMenu
#region Games
	/// <summary>
	/// Азартные игры
	/// 840
	/// </summary>
	static void Games(bool isFirst)
	{
		Functions.ReCalcGames();
		ShowNal();
		Values.N1 += 5;
		TextWriter.Clear();
		TextWriter.ShowMsg(Language.GameHello, 0.5f, 0.003f, 0);
		for (int i=0; i<5; i++)
			TextWriter.ShowMsg(Language.VDG[i]+"\t"+Values.R1[i].ToString().PadRight(10)+Values.R2[i].ToString().PadRight(10)+Values.R3[i]+"\n", 0, 0.003f);

		TextWriter.ShowMsg("\n");
		TextWriter.ShowMsg(Language.WillBuy[8]);
		Controller.GetStr(GamePlays, true);
	}

	/// <summary>
	/// Играем?
	/// 872
	/// </summary>
	static void GamePlays(string pVal)
	{
		if (pVal == "1")
		{
			TextWriter.ShowMsg(Language.GameCh);
			Controller.GetStr(GameNum, true);
		}
		else
		{
			TextWriter.ShowMsg(Language.GameNo);
			Controller.GetStr(CheakNewYear, false);
		}
	}

	/// <summary>
	/// Номер игры
	/// 880
	/// </summary>
	static void GameNum(string pVal)
	{
		int I = 0;
		if (int.TryParse(pVal, out I))
		{
			I--;
			if (I < 0 || I> 4)
				CheakNewYear();
			else
			{
				if (Values.A[0] + Values.A1 < Values.R1[I]) // А хватает ли денег
				{
					DontEnoughtMoney();
				}
				else
				{
					int Y = (int)(Functions.rnd * 100f);
					if (Y < Values.R3[I]) // Выиграли
					{
						Values.A[0] += Values.R2[I];
						TextWriter.ShowMsg(Language.GameWin, 2f);
					}
					else // Проиграли
					{
						Values.A[0] -= Values.R1[I];
						TextWriter.ShowMsg(Language.GameLoose, 2f);
					}
					Controller.GetStr(CheakNewYear, false);
				}
			}
		}
		else
		{
			TextWriter.ShowMsg(Language.retry);
			TextWriter.ShowMsg(Language.GameCh);
			Controller.GetStr(GameNum, true);
		}
	}
#endregion Games
#region BuySell
	/// <summary>
	/// Флаг (1) покупка / (-1) продажа
	/// </summary>
	static int ZFlag = 0;
	
	/// <summary>
	/// Будет ли покупать
	/// 218
	/// </summary>
	static void WaitBuy(string pVal)
	{
		if (pVal == "1")
		{
			ZFlag = 1;
			TextWriter.ShowMsg (Language.What[curMenuFlag]);
			Controller.GetStr (WaitSellPre,true);
		}
		else
		{
			TextWriter.ShowMsg (Language.WillSell[curMenuFlag]);
			Controller.GetStr (WaitSell,true);
		}
	}
	
	/// <summary>
	/// Будет ли продавать
	/// 222
	/// </summary>
	static void WaitSell(string pVal)
	{
		if (pVal == "1")
		{
			ZFlag = -1;
			TextWriter.ShowMsg (Language.What[curMenuFlag]);
			Controller.GetStr (WaitSellPre,true);
		}
		else
		{
			CheakNewYear();
		}
	}

	/// <summary>
	/// Выбор покупка или продажа и для какого раздела
	/// </summary>
	static void WaitSellPre(string pVal)
	{
		int I = 0;
		if (int.TryParse(pVal, out I))
		{
			I = I - 1;
			if (I < 0 || I > 4)
			{
				TextWriter.ShowMsg (Language.Dont[curMenuFlag],0f,0.01f,2f, BackToMenu);
			}
			else
			{
				switch(curMenuFlag)
				{
				case 3 :
					WaitSellOp(I, Values.C, Values.C2, Values.C3);
					break;
				case 4:
					WaitSellOp(I, Values.D, Values.D3, Values.D1);
					break;
				case 5:
					WaitSellOp(I, Values.E, Values.E2, Values.E3);
					break;
				default:
					Debug.LogError("Unknown Op");
					break;
				}
			}
		}
		else
		{
			TextWriter.ShowMsg (Language.retry);
			TextWriter.ShowMsg (Language.What[curMenuFlag]);
			Controller.GetStr (WaitSellPre,true);
		}
	}

	/// <summary>
	/// Выбрали что покупать / продавать
	/// 228
	/// </summary>
	static void WaitSellOp(int I, int[] pArr, int[] pArr2, int[] pArr3)
	{
		if (ZFlag > 0) // Покупка
		{
			if (pArr[I] != 0) // Уже имеем
			{
				TextWriter.ShowMsg (Language.Dont[curMenuFlag],0f,0.01f,2f, BackToMenu);
			}
			else if (Values.A[0] >= pArr2[I])
			{
				if (curMenuFlag == 4)
					Functions.CloseDeal4 (pArr, pArr3, pArr2, I, ZFlag);
				else
					Functions.CloseDeal (pArr, pArr3, pArr2, I, ZFlag);
				TextWriter.ShowMsg (Language.AnotherOne);
				Controller.GetStr(AnotherOne, true);
			}
			else
			{
				DontEnoughtMoney();
			}
		}
		else // Продажа
		{
			if (pArr[I] == 0) // Не имеем
			{
				TextWriter.ShowMsg ("\n");
				TextWriter.ShowMsg (Language.NothingSell[curMenuFlag],1f);
				Controller.GetStr(BackToMenu, false);
			}
			else
			{
				if (curMenuFlag == 4)
					Functions.CloseDeal4 (pArr, pArr3, pArr2, I, ZFlag);
				else
					Functions.CloseDeal (pArr, pArr3, pArr2, I, ZFlag);
				TextWriter.ShowMsg (Language.AnotherOne);
				Controller.GetStr(AnotherOne, true);
			}
		}
	}
	
	static void AnotherOne(string pVal)
	{
		if (pVal == "1")
			NavMenu2 (curMenuFlag.ToString(), false);
		else
			CheakNewYear ();
	}
#endregion BuySell

#region Stat
	static void ShowNal()
	{
		TextWriter.ShowMsg (string.Format (Language.cashe, Values.A [0]));
	}

	static void ShowStat(bool navigate = true)
	{
		int total = Functions.CalcFinance ();
		TextWriter.Clear ();
		TextWriter.ShowMsg ("\n");
		ShowNal ();
		TextWriter.ShowMsg (string.Format (Language.stat, Values.A[1], Values.A1, Values.A[2],Values.A[3],Values.A[4]));
		TextWriter.ShowMsg ("\n");
		TextWriter.ShowMsg (string.Format (Language.total, total));
		if (navigate)
		{
			TextWriter.ShowMsg ("\n\n");
			Controller.GetStr (BackToMenu,false);
		}
	}
#endregion Stat
#region Flat
	static void ShowFlat(bool first = false)
	{
		if (first)
		{
			Values.N1++;
			Functions.RecalcRealtyPrice();
		}
		TextWriter.Clear ();
		TextWriter.ShowMsg ("\n");
		ShowNal ();
		CategoryState state = Functions.ArrStat (Values.C);
		if (state != CategoryState.BUYONLY)
		{
			TextWriter.ShowMsg(Language.canSell[3]);
			for (int i=0; i<Values.C.Length; i++)
			{
				if (Values.C[i] == 1)
					TextWriter.ShowMsg(Language.VBS[i]+"\t\t\t"+Values.C2[i].ToString()+"\n");
			}
		}
		TextWriter.ShowMsg ("\n");
		if (state != CategoryState.SELLONLY)
		{
			TextWriter.ShowMsg(Language.canBuy[3]);
			for (int i=0; i<Values.C.Length; i++)
			{
				if (Values.C[i] == 0)
					TextWriter.ShowMsg(Language.VBS[i]+"\t\t\t"+Values.C3[i].ToString()+"\n");
			}
		}
		TextWriter.ShowMsg ("\n");
		TextWriter.ShowMsg (Language.Expenses);
		TextWriter.ShowMsg ("\n");
		TextWriter.ShowMsg (Language.WillBuy[curMenuFlag]);
		Controller.GetStr (WaitBuy,true);
	}
#endregion Flat
#region Business
	/// <summary>
	/// Показать бизнес
	/// 262
	/// </summary>
	static void ShowBusiness(bool isFirst)
	{
		TextWriter.Clear ();
		ShowNal ();
		TextWriter.ShowMsg ("\n");
		if (isFirst)
		{
			Values.N1++;
			Functions.RecalcBusiness();
		}
		CategoryState state = Functions.ArrStat (Values.E);
		if (state != CategoryState.BUYONLY)
		{
			TextWriter.ShowMsg (Language.canSell[5]);
			for (int i=0; i<5; i++)
			{
				if (Values.E[i] == 1)
					TextWriter.ShowMsg(Language.VDS[i]+"\t\t"+Values.E2[i].ToString().PadRight(10)+"\t"+Values.E1[i]+"\n");
			}
		}

		if (state != CategoryState.SELLONLY)
		{
			TextWriter.ShowMsg (Language.canBuy[5]);
			for (int i=0; i<5; i++)
			{
				if (Values.E[i] == 0)
					TextWriter.ShowMsg(Language.VDS[i]+"\t\t"+Values.E3[i].ToString().PadRight(10)+"\t"+Values.E1[i]+"\n");
			}
		}
		TextWriter.ShowMsg ("\n");
		TextWriter.ShowMsg (Language.WillBuy[curMenuFlag]);
		Controller.GetStr (WaitBuy,true);
	}
#endregion Business
#region Personel
	static void ShowPersonel(bool isFirst)
	{
		TextWriter.Clear ();
		ShowNal ();
		if (isFirst)
		{
			Values.N1++;
			Functions.RecalcPersonel();
		}

		CategoryState state = Functions.ArrStat (Values.D);
		TextWriter.ShowMsg ("\n");
		if (state != CategoryState.BUYONLY)
		{
			TextWriter.ShowMsg (Language.canSell[4]);
			for (int i=0; i<5; i++)
			{
				if (Values.D[i] == 1)
					TextWriter.ShowMsg(Language.VCS[i]+"\t\t\t"+(Values.D1[i]*0.2f).ToString()+"\n");
			}
		}
		
		TextWriter.ShowMsg ("\n");
		if (state != CategoryState.SELLONLY)
		{
			TextWriter.ShowMsg (Language.canBuy[4]);
			for (int i=0; i<5; i++)
			{
				if (Values.D[i] == 0)
					TextWriter.ShowMsg(Language.VCS[i]+"\t\t\t"+Values.D1[i].ToString()+"\n");
			}
		}

		TextWriter.ShowMsg ("\n");
		TextWriter.ShowMsg (Language.WillBuy[curMenuFlag]);
		Controller.GetStr (WaitBuy,true);
	}
#endregion Personel
#region Stock
	/// <summary>
	/// Shows the stock
	/// 738
	/// </summary>
	static void ShowStock(bool isFirst)
	{
		if (isFirst)
			Functions.ReCalcStock();

		TextWriter.Clear ();
		if (Values.N1 > Values.N4)
		{
			TextWriter.ShowMsg(Language.STClose);
			Controller.GetStr (CheakNewYear, false);
		}
		else
		{
			Values.N1 ++;
			if (!Accident())
				ShowStock2();
		}
	}

	/// <summary>
	/// Показываем инфо об акциях
	/// 742
	/// </summary>
	static void ShowStock2(string pVal = "")
	{
		TextWriter.ShowMsg(Language.STHello);
		for (int i=0; i<5; i++)
			TextWriter.ShowMsg(Language.VDF[i]+"\t"+Values.F[i].ToString()+"\t\t"+Values.F1[i].ToString()+"\t\t"+Values.F2[i].ToString()+"\n");
		TextWriter.ShowMsg("\n");
		ShowNal ();
		TextWriter.ShowMsg("\n");
		TextWriter.ShowMsg(Language.WillBuy[6]);
		Controller.GetStr(StockBuy, true);
	}

	static int IFlag = 0;
	/// <summary>
	/// Покупаете? 
	/// 766
	/// </summary>
	static void StockBuy(string pVal)
	{
		if (pVal == "1")
		{
			ZFlag = 1;
			TextWriter.ShowMsg(Language.What[6]);
			Controller.GetStr(StockWhat, true);
		}
		else
		{
			TextWriter.ShowMsg(Language.WillSell[6]);
			Controller.GetStr(StockSell, true);
		}
	}

	/// <summary>
	/// Продаёте?
	/// 770
	/// </summary>
	static void StockSell(string pVal)
	{
		if (pVal == "1")
		{
			ZFlag = -1;
			TextWriter.ShowMsg(Language.What[6]);
			Controller.GetStr(StockWhat, true);
		}
		else
			CheakNewYear();
	}

	/// <summary>
	/// Что покупкаем
	/// 774
	/// </summary>
	static void StockWhat(string pVal)
	{
		if (int.TryParse(pVal, out IFlag))
		{
			IFlag --;
			if (IFlag < 0 || IFlag > 4)
				CheakNewYear();
			else if (Values.J[IFlag] == IFlag) // Только один раз в год операция с одним типом акций
			{
				if (ZFlag > 0)
					TextWriter.ShowMsg(Language.Dont[1]);
				else
					TextWriter.ShowMsg(Language.Dont[2]);
				TextWriter.ShowMsg(Language.AnotherOne);
				Controller.GetStr(AnotherOne, true);
			}
			else
			{
				TextWriter.ShowMsg(Language.canBuy[2]);
				Controller.GetStr(StockMany, true);
			}
		}
		else
		{
			TextWriter.ShowMsg(Language.retry);
			TextWriter.ShowMsg(Language.What[6]);
			Controller.GetStr(StockWhat, true);
		}
	}

	/// <summary>
	/// Сколько покупаем
	/// 784
	/// </summary>
	static void StockMany(string pVal)
	{
		int cnt = 0;
		if (int.TryParse(pVal, out cnt))
		{
			Values.J[IFlag] = IFlag;
			if (ZFlag < 0) // Продажа
			{
				if (Values.F[IFlag] < cnt)
				{
					TextWriter.ShowMsg(string.Format(Language.STHavent, Values.F[IFlag], cnt));
					Controller.GetStr(CheakNewYear, false);
				}
				else
				{
					int W = (105 - Values.F1[IFlag]) * 5 * Values.S;
					if (cnt > W)
					{
						TextWriter.ShowMsg(string.Format(Language.STSell, W));
						cnt = W;
					}
					int Y = (int)(cnt * Values.F1[IFlag]);
					Values.F[IFlag] -= cnt;
					Values.A[0] += Y;
					TextWriter.ShowMsg(Language.AnotherOne);
					Controller.GetStr(AnotherOne, true);
				}
			}
			else // Покупка
			{
				if (cnt * Values.F1[IFlag] > Values.A[0])
				{
					TextWriter.ShowMsg(Language.STDis);
					DontEnoughtMoney();
				}
				else
				{
					int W2 = Values.F1[IFlag] * 5 * Values.S;
					if (cnt > W2)
					{
						TextWriter.ShowMsg(string.Format(Language.STBuy, W2));
						cnt = W2;
					}
					int Y2 = Values.F1[IFlag] * cnt;
					Values.F[IFlag] += cnt;
					Values.A[0] -= Y2;
					TextWriter.ShowMsg(Language.AnotherOne);
					Controller.GetStr(AnotherOne, true);
				}
			}
		}
		else
		{
			TextWriter.ShowMsg(Language.retry);
			TextWriter.ShowMsg(Language.canBuy[2]);
			Controller.GetStr(StockMany, true);
		}
	}

	/// <summary>
	/// ущерб
	/// </summary>
	static int accDamage = 0;

	/// <summary>
	/// Произошла ли фигня при занятии бизнесом
	/// 416
	/// </summary>
	static bool Accident()
	{
		int acc = 0;
		if (Functions.Accident(out accDamage, out acc))
		{
			switch (acc)
			{
				case 0: // Маклер
					TextWriter.ShowMsg(string.Format(Language.ACC0, accDamage));
					Values.A[0] -= accDamage;
					Controller.GetStr (ShowStock2, false);
				break;
				case 1: // Больница
					TextWriter.ShowMsg(string.Format(Language.ACC1, accDamage));
					Values.A[0] -= accDamage;
					Controller.GetStr (ShowStock2, false);
				break;
				case 2: // Адвокат
					TextWriter.ShowMsg(string.Format(Language.ACC2, (accDamage / 2)));
					Controller.GetStr (AccAdv, true);
				break;
				case 3: // Детектив
					TextWriter.ShowMsg(string.Format(Language.ACC3, accDamage));
					Values.A[0] -= accDamage;
					Controller.GetStr (ShowStock2, false);
				break;
				default: // Забрали все ценные бумаги
					TextWriter.ShowMsg(string.Format(Language.ACC4, accDamage));
					Controller.GetStr (ShowStock2, false);
				break;
			}
			return true;
		}
		else
			return false;
	}

	/// <summary>
	/// Наняли ли адвоката
	/// 454
	/// </summary>
	static void AccAdv(string pVal)
	{
		if (pVal == "1")
		{
			TextWriter.ShowMsg(Language.ACCW);
			Values.A[0] -= accDamage / 2;
			Controller.GetStr (ShowStock2, false);
		}
		else
		{
			TextWriter.ShowMsg(string.Format(Language.ACC3, accDamage));
			Values.A[0] -= accDamage;
			Controller.GetStr (ShowStock2, false);
		}
	}

#endregion Stock
#region Bank
	/// <summary>
	/// Банковские операции
	/// 514
	/// </summary>
	static void ShowBank(bool isFirst)
	{
		int ret = Functions.Bankrot;
		if (ret >0)
		{
			TextWriter.ShowMsg (string.Format(Language.Bankrote,ret));
			Controller.GetStr (BackToMenu,false);
		}
		else
		{
			TextWriter.Clear ();
			TextWriter.ShowMsg (Language.BankHello);
			Values.N1++;
			if (Values.S4 == 0) //4
				TextWriter.ShowMsg (Language.BankGivKr);
			if (Values.K4 == 0) //5
				TextWriter.ShowMsg (Language.BankGetKr);
			TextWriter.ShowMsg ("? ");
			Controller.GetStr (BankNav,true);
		}
	}

	/// <summary>
	/// Навигация по меню банка
	/// 532
	/// </summary>
	static void BankNav(string pVal)
	{
		TextWriter.ShowMsg ("\n");
		switch (pVal)
		{
			case "1": // Застраховать 580
				TextWriter.ShowMsg (Language.BankStr);
				ShowHaveTxt(Values.C, Language.VBS, 1, Language.have);
				TextWriter.ShowMsg (Language.BankSCost);
				TextWriter.ShowMsg (Language.BankStr2);
				Controller.GetStr(BankStr,true);
			break;
			case "2": // Положить на счёт 560
				ShowNal();
				TextWriter.ShowMsg(string.Format(Language.BankPerc, Values.S * 2));
				TextWriter.ShowMsg(Language.BankCost);
				TextWriter.ShowMsg(Language.BankSet);
				Controller.GetStr(bankSet, true);
			break;
			case "3": // Снять со счёта 544
				TextWriter.ShowMsg(string.Format(Language.BankAkk, Values.A1));
				TextWriter.ShowMsg(Language.BankCost);
				TextWriter.ShowMsg(Language.BankGet);
				Controller.GetStr(bankGet, true);
			break;
			case "4": // Дать сууду 1146
				if (Values.S4 == 0)	 // В оригинале этого нет
				{
					ShowNal();
					TextWriter.ShowMsg (Language.SsudHello);
					TextWriter.ShowMsg (Language.SsudMany);
					Controller.GetStr(Ssud, true);
				}
				else
					CheakNewYear();
			break;
			case "5":	// Получить кредит
				if (Values.K4 == 0)	// В оригинале этого нет
				{
					ShowNal();
					Values.K5 = Functions.CalcFinance();
					if (Values.K5 < 0)
					{
						TextWriter.ShowMsg (Language.KredNo);
						Controller.GetStr(CheakNewYear, false);
					}
					else
					{
						TextWriter.ShowMsg (string.Format(Language.KredHello, Values.K5));
						Controller.GetStr(Kred, true);
					}
				}
				else
					CheakNewYear();
			break;
			default:
				CheakNewYear();
			break;
		}
	}

	/// <summary>
	/// Получить кредит
	/// 1192
	/// </summary>
	static void Kred(string pVal)
	{
		int i = 0;
		if (int.TryParse(pVal, out i))
		{
			Values.K1 = i;
			TextWriter.ShowMsg(Language.KredMany);
			Controller.GetStr(Kred2, true);
		}
		else
		{
			TextWriter.ShowMsg(Language.retry);
			Controller.GetStr(Kred, true);
		}
	}

	/// <summary>
	/// На какой срок
	/// 1194
	/// </summary>
	static void Kred2(string pVal)
	{
		int i = 0;
		if (int.TryParse(pVal, out i))
		{
			if (i > 5)
			{
				TextWriter.ShowMsg(Language.Dont[0]);
				TextWriter.ShowMsg(Language.KredMany);
				Controller.GetStr(Kred2, true);
			}
			else
			{
				Values.K2 = i;
				Values.K3 = Functions.Round2((float)Values.K1 / (float)Values.K5);
				TextWriter.ShowMsg(string.Format(Language.KredPerc, (Values.K3 * 100)));
				Controller.GetStr(Kred3, true);
			}
		}
		else
		{
			TextWriter.ShowMsg(Language.retry);
			TextWriter.ShowMsg(Language.KredMany);
			Controller.GetStr(Kred2, true);
		}
	}

	/// <summary>
	/// Получение кредита
	/// 1202
	/// </summary>
	static void Kred3(string pVal)
	{
		if (pVal == "1")
		{
			TextWriter.ShowMsg(string.Format(Language.KredWhen, (Values.M + Values.N + Values.K2)));
			Values.A[0] += Values.K1;
			Values.K4 = 1;
			Controller.GetStr(CheakNewYear, false);
		}
		else
			CheakNewYear();
	}
	/// <summary>
	/// Дать ссуду
	/// 1152
	/// </summary>
	/// <param name="pVal">P value.</param>
	static void Ssud(string pVal)
	{
		int i = 0;
		if (int.TryParse(pVal, out i))
		{
			if (i > Values.A[0] + Values.A1)
				DontEnoughtMoney();
			else
			{
				Values.S1 = i;
				TextWriter.ShowMsg(Language.BankStr6);
				Controller.GetStr(Ssud2, true);
			}
		}
		else
		{
			TextWriter.ShowMsg(Language.retry);
			Controller.GetStr(Ssud, true);
		}
	}


	/// <summary>
	/// На какой срок
	/// 1158
	/// </summary>
	static void Ssud2(string pVal)
	{
		int i = 0;
		if (int.TryParse(pVal, out i))
		{
			if (i>10 || i<1)
			{
				TextWriter.ShowMsg(Language.Dont[7]);
				TextWriter.ShowMsg(Language.BankStr6);
				Controller.GetStr(Ssud2, true);
			}
			else
			{
				Values.S6 = i;
				TextWriter.ShowMsg(Language.SsudProc);
				Controller.GetStr(Ssud3, true);
			}
		}
		else
		{
			TextWriter.ShowMsg(Language.retry);
			Controller.GetStr(Ssud2, true);
		}
	}

	/// <summary>
	/// Под какие проценты
	/// 1162
	/// </summary>
	static void Ssud3(string pVal)
	{
		int i = 0;
		if (int.TryParse(pVal, out i))
		{
			if (i > 20)
				Values.S2 = 0.1f;
			else
				Values.S2 = i;

			Values.S3 = Functions.Round2(50f / (60f + Values.S2));
			Values.S2 = Functions.Round2(Values.S2 / 100f);

			TextWriter.ShowMsg(string.Format(Language.SsudOff,  Functions.Round2(Values.S1 * Values.S2)));
			Controller.GetStr(Ssud4, true);
		}
		else
		{
			TextWriter.ShowMsg(Language.retry);
			TextWriter.ShowMsg(Language.SsudProc);
			Controller.GetStr(Ssud3, true);
		}
	}

	/// <summary>
	/// По рукам?
	/// 1170
	/// </summary>
	static void Ssud4(string pVal)
	{
		if (pVal == "1")
		{
			Values.S4 = 1;
			Values.A[0] -= Values.S1;

			float Y = Functions.rnd;
			if (Y < Values.S3)
				Values.S5 = 1;
			else
				Values.S5 = 0;
			CheakNewYear();
		}
		else
			CheakNewYear();
	}

	/// <summary>
	/// Страховка в банке
	/// 590
	/// </summary>
	/// <param name="pVal">P value.</param>
	static void BankStr(string pVal)
	{
		if (pVal == "1")
		{
			TextWriter.Clear();
			TextWriter.ShowMsg(Language.BankStr3);
			for (int i=0; i<Values.C.Length; i++)
			{
				if (Values.C[i] == 1)
					TextWriter.ShowMsg(Language.VBS[i]+"\t\t\t"+Values.C2[i].ToString()+"\n");
			}
			TextWriter.ShowMsg(Language.BankStr4);
			Controller.GetStr(bankStr2, true);
		}
		else
			CheakNewYear();
	}

	/// <summary>
	/// Номер страхуемой позиции
	/// </summary>
	static int sNo = 0;

	/// <summary>
	/// Что Страхуем
	/// 594
	/// </summary>
	static void bankStr2(string pVal)
	{
		sNo = 0;
		if (int.TryParse(pVal, out sNo))
		{
			if (sNo > 5 || sNo <=0)
				CheakNewYear();
			else
			{
				sNo--;
				Values.G2[sNo] = sNo;
				Values.G3[sNo] = 1;
				TextWriter.ShowMsg(Language.BankStr5); // На какую суму
				Controller.GetStr(BankStr3, true);
			}
		}
		else
			BankStr("1");
	}

	/// <summary>
	/// Страховка на Сумму
	/// 604
	/// </summary>
	static void BankStr3(string pVal)
	{
		int i = 0;
		if (int.TryParse(pVal, out i))
		{
			Values.G[sNo] = i;
			TextWriter.ShowMsg(Language.BankStr6); // На какой срок
			Controller.GetStr(BankStr4, true);
		}
		else
		{
			TextWriter.ShowMsg(Language.retry);
			Controller.GetStr(BankStr3, true);
		}
	}

	/// <summary>
	/// Страховка 
	/// 608
	/// </summary>
	static void BankStr4(string pVal)
	{
		int i = 0;
		if (int.TryParse(pVal, out i))
		{
			Values.G1[sNo] = i;
			TextWriter.ShowMsg(Language.BankStr7);
			Controller.GetStr(BankStr5, true);
		}
		else
		{
			TextWriter.ShowMsg(Language.retry);
			Controller.GetStr(BankStr4, true);
		}
	}

	/// <summary>
	/// Ещё одна страховка?
	/// 612
	/// </summary>
	static void BankStr5(string pVal)
	{
		if (pVal == "1")
			BankStr ("1");
		else
			CheakNewYear ();
	}

	/// <summary>
	/// Снять со счёта
	/// 550
	/// </summary>
	static void bankGet(string pVal)
	{
		int X = 0;
		if (int.TryParse(pVal, out X))
		{
			if (X <= Values.A1)
			{
				Functions.BankGet(X);
				CheakNewYear();
			}
			else
				DontEnoughtMoney();
		}
		else
			CheakNewYear();
	}

	/// <summary>
	/// Сделать вклад
	/// </summary>
	static void bankSet(string pVal)
	{
		int X = 0;
		if (int.TryParse(pVal, out X))
		{
			if (X <= Values.A[0])
			{
				Functions.BankSet(X);
				CheakNewYear();
			}
			else
				DontEnoughtMoney();
		}
		else
			CheakNewYear();
	}

#endregion Bank

#region ObStat

	/// <summary>
	/// Должность на которую претендует
	/// </summary>
	static int VybDol = 0;
	/// <summary>
	/// Общественное положение
	/// 616
	/// </summary>
	static void ShowObStat(bool isFirst)
	{
		TextWriter.Clear();
		TextWriter.ShowMsg("\n\n");
		if (Values.B3 != 0)
		{
			TextWriter.ShowMsg(Language.VybWas);
			Controller.GetStr(CheakNewYear, false);
		}
		else if (!Functions.VybYear)
		{
			Values.B3 = 1;
			TextWriter.ShowMsg(Language.VybNot);
			Controller.GetStr(CheakNewYear, false);
		}
		else
		{
			ShowNal();
			ShowHaveTxt(Values.B, Language.VAS, 1, Language.you);
			TextWriter.ShowMsg(Language.VybHello);

			VybDol = Functions.RecalcStat();

			if (VybDol == 4)
			{
				TextWriter.ShowMsg(Language.VybFin);
				Controller.GetStr(CheakNewYear, false);
			}
			else
			{
				TextWriter.ShowMsg(Language.VAS2[VybDol]);
				TextWriter.ShowMsg("\t\t\t"+Values.B1[VybDol].ToString()+"\t\t"+(Values.B2[VybDol]*100).ToString()+"\n\n");
				TextWriter.ShowMsg(Language.Vyb);
				Controller.GetStr(Vyb, true);
			}
		}
	}

	/// <summary>
	/// Участие в выборах
	/// 694
	/// </summary>
	static void Vyb(string pVal)
	{
		TextWriter.ShowMsg("\n");
		Values.B3 = 1;
		Values.N++;
		if (pVal == "1")
		{
			if (Values.A[0] + Values.A1 < Values.B1[VybDol])
			{
				DontEnoughtMoney();
			}
			else
			{
				Values.A[0] -= Values.B1[VybDol];
				float Y = Functions.rnd;
				if (Y >= Values.B2[VybDol]) // проигрыш
				{
					TextWriter.ShowMsg(string.Format(Language.VybFail, (Y * 50)));
					Controller.GetStr(CheakNewYear, false);
				}
				else // Выиграли
				{
					Values.S++;
					Values.B[VybDol] = 1;
					Values.B[VybDol-1] = 0;
					TextWriter.ShowMsg(Language.VybWin + Language.VAS[VybDol]);
					if (VybDol == 4)
						TextWriter.ShowMsg(Language.VybFin);
					Controller.GetStr(CheakNewYear, false);
				}
			}
		}
		else
		{
			TextWriter.ShowMsg(Language.VybDis);
			Controller.GetStr(CheakNewYear, false);
		}
	}
#endregion

#region BetweenPages

	/// <summary>
	/// Показать текст того что имеем
	/// 140
	/// </summary>
	/// <param name="have">Массив имеемого</param>
	/// <param name="names">Имена</param>
	/// <param name="check">Что показывать (-1 - всё, 0 - не имеем, 1 - имеем)</param>
	/// <param name="pMessage">Заголовок</param>
	static void ShowHaveTxt(int[] have, string[] names, int check, string pMessage)
	{
		TextWriter.ShowMsg (pMessage, 0.5f);
		for (int i=0; i<5; i++)
		{
			if (check== -1 || check == have[i])
				TextWriter.ShowMsg (names [i]+"\n");
		}
	}

	/// <summary>
	/// Не хватило денег на операцию. Штраф!
	/// </summary>
	static void DontEnoughtMoney()
	{
		TextWriter.ShowMsg ("\n");
		int Q = (int)(1000f + 500f * Functions.rnd);
		TextWriter.ShowMsg(string.Format(Language.NotEnought, Q.ToString()), 1f, 0.02f);
		Values.A[0] -= Q;
		Controller.GetStr (CheakNewYear,false);
	}

	/// <summary>
	/// Несчастные случаи
	/// 1240
	/// </summary>
	static bool CheckFail()
	{
		if (Functions.rnd > 0.2f)
			return true;

		int I = (int) (Functions.rnd * 10);
		if (I < 1 || I >=5)
			return true;

		if (Values.C[I] == 0)
			return true;

		if (Values.G3[I] != 0) //1256
		{
			if (Values.G[I] > Values.C2[I] * 1.5f) //1258
				return true;
		}

		int X = Values.C2[I];

		switch (I)
		{
			case 1: // На машине разбились 1272
				TextWriter.ShowMsg(Language.CrashCar);
			break;
			case 2: // Вилла 1276
				TextWriter.ShowMsg(Language.CrashVil);
			break;
			case 3: // Яхта 1278
				TextWriter.ShowMsg(Language.CrashYac);
			break;
			default: // На самолёте разбились 1268
				TextWriter.ShowMsg(Language.CrashFly);
				return false;
			break;
		}

		TextWriter.ShowMsg(string.Format(Language.CrashAcc, X), 0, 0.01f, 1f);

		if (Values.G3[I] > 0)
			TextWriter.ShowMsg(string.Format(Language.CrashEns, Values.G[I]));

		Functions.Crash(I, X);

		TextWriter.ShowMsg("\n",2f);
		return true; // остался жив
	}

	/// <summary>
	/// Конец года
	/// </summary>
	static void CheakNewYear(string pval = "")
	{
		if (!CheckFail())
			Retry();
		else if (Values.N1 < Values.N4 && Values.A[0] >= 0)
			ShowMainMenu (true);
		else
		{
			TextWriter.ShowMsg(string.Format(Language.NYHello, (Values.N + Values.M))); //960
			Values.N++;
			Values.N2++;

			if (Functions.ArrStat(Values.B) != CategoryState.BUYONLY)
				ShowHaveTxt(Values.B, Language.VAS, 1, Language.you);
			if (Functions.ArrStat(Values.C) != CategoryState.BUYONLY)
				ShowHaveTxt(Values.C, Language.VBS, 1, Language.have);
			if (Functions.ArrStat(Values.D) != CategoryState.BUYONLY)
				ShowHaveTxt(Values.D, Language.VCS, 1, Language.payfor);
			if (Functions.ArrStat(Values.E) != CategoryState.BUYONLY)
				ShowHaveTxt(Values.E, Language.VDS, 1, Language.have);

			ShowStat(false);

			Functions.CalcFinance();

			TextWriter.ShowMsg(Language.NYPay);
			Controller.GetStr(NYPay, true);
		}
	}

	/// <summary>
	/// Оплачиваем расходы
	/// 982
	/// </summary>
	static void NYPay(string pVal)
	{
		if (Values.C[0] + Values.C[2] == 0) //Бродяжничество 992
			TextWriter.ShowMsg(string.Format(Language.NYFl, Functions.Penalty), 0, 0.01f, 2f);

		if (pVal != "1") // Жмотничество 1004
			TextWriter.ShowMsg(string.Format(Language.NYNA, Functions.Penalty), 0, 0.01f, 2f);

		Functions.CalcNY();

		if (Values.A[0] < 0) // Дефицит средств
		{
			TextWriter.ShowMsg(string.Format(Language.NYNal, Values.A[0]));
			if (Values.A1 > 0)
			{
				TextWriter.ShowMsg(string.Format(Language.BankAkk, Values.A1));
				TextWriter.ShowMsg(Language.BankCost);
				TextWriter.ShowMsg(Language.BankGet);
				Controller.GetStr(NYbankGet, true);
			}
			else
				NYPay2();
		}
		else
			NYPay2();
	}

	/// <summary>
	/// Продолжаем оплачивать расходы
	/// 1018
	/// </summary>
	static void NYPay2(string pVal = "")
	{
		if (Values.A[0] < 0)
		{
			if (Values.A[1] > 0) // Акции
			{
				TextWriter.ShowMsg(string.Format(Language.NYSellS, Functions.SellStock)); //1072
				Controller.GetStr(NYPay2, false);
			}
			else if (Values.A[2] > 0) // Имущество и подчинённые
			{
				TextWriter.ShowMsg(string.Format(Language.NYSellF, Functions.SellFlat)); // 1088
				Controller.GetStr(NYPay2, false);
			}
			else // Банкрот 1106
			{
				int X = Functions.Jail;
				if (X > 15)
				{
					TextWriter.ShowMsg(Language.NYDead);
					Retry();
				}
				else
				{
					TextWriter.ShowMsg(string.Format(Language.NYJail, X));
					Controller.GetStr(AfterJail, false);
				}
			}
		}
		else // 1022
		{
			if (Values.N2 > Values.N3) // X-|
			{
				TextWriter.ShowMsg(string.Format(Language.GameOver, Values.N3));
				Retry();
			}
			else
				NewYear();
		}
	}

	/// <summary>
	/// Просмотр рекламы в тюрьме
	/// </summary>
	static void AfterJail(string pVal)
	{
		NewYear ();
	}

	/// <summary>
	/// Наступил новый год
	/// 1020
	/// </summary>
	static void NewYear(string pVal = "")
	{
		TextWriter.ShowMsg(string.Format(Language.NYNew, Values.M+Values.N));
		Values.N1 = 0;
		Values.B3 = 0;
		Functions.RecalcBusiness();
		Functions.ReCalcStr();
		int X = Functions.Kred;
		if (X > 0)
			TextWriter.ShowMsg(string.Format(Language.NYKr, X));
		
		X = Functions.Ssud;
		if (X>0)
			TextWriter.ShowMsg(string.Format(Language.NYSg, X));
		else if (X<0)
			TextWriter.ShowMsg(Language.NYSf);
		if (Values.A[0] < 0)
			NYPay2();
		else
		{
			Values.N4 = (int)(2 + 3 * Functions.rnd);
			ShowMainMenu(true);
		}
	}

	/// <summary>
	/// Снять со счёта для погашение задолженности
	/// </summary>
	static void NYbankGet(string pVal)
	{
		int X = 0;
		if (int.TryParse(pVal, out X))
		{
			if (X <= Values.A1)
			{
				Functions.BankGet(X);
				NYPay2();
			}
			else
			{
				TextWriter.ShowMsg(string.Format(Language.BankAkk, Values.A1));
				TextWriter.ShowMsg(Language.BankCost);
				TextWriter.ShowMsg(Language.BankGet);
				Controller.GetStr(NYbankGet, true);
			}
		}
		else
		{
			TextWriter.ShowMsg(Language.retry);
			TextWriter.ShowMsg(Language.BankGet);
			Controller.GetStr(NYbankGet, true);
		}
	}

	/// <summary>
	/// Начать заново
	/// </summary>
	static void Retry()
	{
		TextWriter.ShowMsg (Language.GameRet);
		Controller.GetStr (Retry2, true);
	}

	/// <summary>
	/// Начнём ка сначала
	/// </summary>
	static void Retry2(string pVal)
	{
		StartGame ();
	}
#endregion BetweenPages

}
