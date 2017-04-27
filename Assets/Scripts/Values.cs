using UnityEngine;
using System.Collections;

/// <summary>
/// Состояние категории
/// </summary>
public enum CategoryState : byte
{
	 BUYONLY = 0
	,BOTH = 1
	,SELLONLY = 2
}

/// <summary>
/// Переменные игры
/// </summary>
public static class Values
{
	public static int M  = 0;	  	// M  - Год начала

	public static int S  = 1;		// Текущий общественынй статус. Он же проценты по вкладу

	public static int	S1 = 0;		// Сумма ссуды
	public static float S2 = 0;		// Процент ссуды
	public static float S3 = 0;		// 
	public static int   S4 = 0;		// 1 - Ссуда выдана
	public static int   S5 = 0;		// 1 - Успешно ссудили 0 - не очень успешно. Случайный фактор
	public static float S6 = 0;		// Срок ссуды

	public static int   K1 = 0;		// Сумма кредита
	public static int   K2 = 0;		// Срок кредита
	public static float K3 = 0;		// Проценты
	public static int   K4 = 0;		// 1 - Кредит выдан
	public static int   K5 = 0;		// K5 - Категория сложности (фейк) в кредите - сумма всего имущества

	public static   int N  = 0;		// Номер текущего года
	public static   int N1 = 0;		// N1 - Номер дня в году
	public static   int N2 = 0;		// N2 - Возраст
	public static float N3 = 0;		// N3 - Сколько отмерено лет
	public static float N4 = 0;		// Сколько дней в году (на самом деле операций)

	public static int[] A  = new int[5]{15000,0,0,0,0};		// Финансы
	public static int   A1 = 0;								// Счёт в банке

	public static int[] B  = new int[5]{1,0,0,0,0};		// Общественное положение
	public static int[] B1 = new int[5]{0,0,0,0,0};		// Стоимость выборов
	public static float[] B2 = new float[5]{0,0,0,0,0};		// Вероятность победы
	public static int   B3 = 0;							// Были ли выборы в этом году

	public static int[] C  = new int[5]{0,0,0,0,0};		// Недвижимость (1 - принадлежит)
	public static int[] C2 = new int[5]{0,0,0,0,0};		// Цена продажи
	public static int[] C3 = new int[5]{0,0,0,0,0};		// Цена покупки

	public static int[] D  = new int[5]{0,0,0,0,0};		// Подчинённые
	public static int[] D1 = new int[5]{0,0,0,0,0};		// Стоимость наёма в год
	public static int[] D3 = new int[5]{0,0,0,0,0};		// Стоимость увольнения

	public static int[] E  = new int[5]{0,0,0,0,0};		// Бизнес ( 1- принадлежит)
	public static int[] E1 = new int[5]{0,0,0,0,0};		// Годовой доход
	public static int[] E2 = new int[5]{0,0,0,0,0};		// Стоимость продажи
	public static int[] E3 = new int[5]{0,0,0,0,0};		// Стоимость покупки

	public static int[] F  = new int[5]{0,0,0,0,0};		// Акций имеем
	public static int[] F1 = new int[5]{0,0,0,0,0};		// Курс акции
	public static float[] F2 = new float[5]{0,0,0,0,0};		// Дивиденты

	public static int[] G  = new int[5]{0,0,0,0,0};		// На какую сумму застраховано
	public static int[] G1 = new int[5]{0,0,0,0,0};		// На какой срок застраховано
	public static int[] G2 = new int[5]{0,0,0,0,0};
	public static int[] G3 = new int[5]{0,0,0,0,0};

	// Азартные игры
	public static int[] R1 = new int[5]{0,0,0,0,0};		// Затраты
	public static int[] R2 = new int[5]{0,0,0,0,0};		// Возможный доход
	public static int[] R3 = new int[5]{0,0,0,0,0};		// Вероятность выигрыша

	public static int[] J = new int[5]{0,0,0,0,0};		// С какими акциями были операции в этом году

	public static int MaxStartCash;

	public static void Init()
	{
		MaxStartCash = (int)(1000f + 500f * Functions.rnd);
		N  = 0;
		N1 = 0;
		N2 = 18;
		N3 = 60f + 20f * Functions.rnd;
		N4 = 2f + 3f * Functions.rnd;
		M  = 0;	  	// M  - Год начала
		S  = 1;		// Текущий общественынй статус. Он же проценты по вкладу
		
		S1 = 0;	S2 = 0;	S3 = 0;	S4 = 0;	S5 = 0;	S6 = 0;
		K1 = 0;	K2 = 0;	K3 = 0;	K4 = 0;	K5 = 0;

		A  = new int[5]{0,0,0,0,0};	A1 = 0;
		
		B3 = 0; B  = new int[5]{1,0,0,0,0};	B1 = new int[5]{0,0,0,0,0};	B2 = new float[5]{0,0,0,0,0};
		C  = new int[5]{0,0,0,0,0};	C2 = new int[5]{0,0,0,0,0};	C3 = new int[5]{0,0,0,0,0};
		D  = new int[5]{0,0,0,0,0};	D1 = new int[5]{0,0,0,0,0};	D3 = new int[5]{0,0,0,0,0};
		E  = new int[5]{0,0,0,0,0};	E1 = new int[5]{0,0,0,0,0};	E2 = new int[5]{0,0,0,0,0};	E3 = new int[5]{0,0,0,0,0};
		F  = new int[5]{0,0,0,0,0}; F1 = new int[5]{0,0,0,0,0}; F2 = new float[5]{0,0,0,0,0};
		G  = new int[5]{0,0,0,0,0};	G1 = new int[5]{0,0,0,0,0};	G2 = new int[5]{0,0,0,0,0};	G3 = new int[5]{0,0,0,0,0};
		R1 = new int[5]{0,0,0,0,0};	R2 = new int[5]{0,0,0,0,0};	R3 = new int[5]{0,0,0,0,0};
		J = new int[5]{0,0,0,0,0};
	}
}
