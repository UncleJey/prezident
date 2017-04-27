﻿using UnityEngine;
using System.Collections;

public class Language
{

	public static string retry = "?ПОВТОРИТЕ ВВОД\n";

	public static string gettime = "ВВЕДИТЕ ВРЕМЯ (ЧАС.МИН)? ";
	public static string getyear = "ВВЕДИТЕ ГОД? ";
	public static string getlev = "ВВЕДИТЕ КАТЕГОРИЮ СЛОЖНОСТИ 0,1,2, И Т.Д.? ";

	public static string hello  = "    ПОЗДРАВЛЯЕМ ВАС С ПРИБЫТИЕМ\n        В НАШУ СТРАНУ,\n";
	public static string hello2 = "    ГДЕ КАЖДЫЙ МОЖЕТ СТАТЬ ПРЕЗИДЕНТОМ!!!\n";
	public static string canbe = "МОЖНО ДАЖЕ ПРЕДСТАВИТЬ, ЧТО . . .\n";
	public static string have = "ВЫ ИМЕЕТЕ -\n";
	public static string payfor = "ОПЛАЧИВАЕТЕ УСЛУГИ-\n";
	public static string bill2 = "И СЧЁТ В БАНКЕ - 1 000 000&,НО ПОКА ЭТО МЕЧТЫ.\nРЕАЛИЗУЙТЕ ИХ\n";
	public static string age = " ВАШ ВОЗРАСТ ? ";
	public static string mummy = "ЗРЯ ЕХАЛИ, В МУМИЯХ НЕ НУЖДАЕМСЯ\n";
	public static string young = "МЛАДЕНЦАМ У НАС ДЕЛАТЬ НЕЧЕГО\n";
	public static string cash = "СКОЛЬКО ИМЕЕТЕ НАЛИЧНЫМИ ? ";
	public static string toomuch = "ГДЕ ВЫ СТОЛЬКО ДОБЫЛИ. ПО НАШИМ ДАННЫМ У ВАС\n";

	public static string you = "В НАСТОЯЩЕЕ ВРЕМЯ ВЫ - ";
	public static string VybNot = "СОЖАЛЕЕМ, НО В ЭТОМ ГОДУ ВЫБОРЫ НЕ ПРОВОДЯТСЯ\n";
	public static string VybHello = "В ЭТОМ ГОДУ ВЫ МОЖЕТЕ ПРИНЯТЬ УЧАСТИЕ В ВЫБОРАХ\n\nЕСТЬ\tПРЕДВЫБОНАЯ КАМПАНИЯ\tВЕРОЯТНОСТЬ\nМЕСТО\t\tОБОЙДЁТСЯ В -\t\tУСПЕХА В %\n\n";
	public static string Vyb = "УЧАСТВУЕТЕ В ВЫБОРАХ ? ";
	public static string VybDis = "ТРУС НЕ ИГРАЕТ В ХОККЕЙ.\nCЛЕДУЮЩИЕ ВЫБОРЫ ЧЕРЕЗ 2 ГОДА\n";
	public static string VybFail = "ВЫ НЕ ПОЛЬЗУЕТЕСЬ ПОПУЛЯРНОСТЬЮ ИЗБИРАТЕТЕЙ\nВАС ПРОКАТИЛИ. ВЫ НАБРАЛИ ТОЛЬКО {0}% ГОЛОСОВ\n";
	public static string VybWin = "ПОЗДРАВЛЯЕМ ВАС. ТЕПЕРЬ ВЫ - ";
	public static string VybFin = "ВЫ ДОСТИГЛИ НЕВОЗМОЖНОГО !!!\nБОЛЬШЕ ЖЕЛАТЬ НЕЧЕГО\n";
	public static string VybWas    = "У ВАС СКЛЕРОЗ.\nВ ЭТОМ ГОДУ ВЫ УЖЕ УЧАСТВОВАЛИ В ВЫБОРАХ\n";

	public static string STClose = "БИРЖА ЗАКРЫТА НА КАНИКУЛЫ\n";
	public static string STHello = "ТЕКУЩЕЕ ПОЛОЖЕНИЕ БИРЖЕВЫХ ДЕЛ -\n\nАКЦИИ\nФИРМЫ\t\t   ИМЕЕТЕ\tКУРС\tДИВИДЕНТЫ %\n\n";
	public static string STHavent = "ВЫ ИМЕЕТЕ {0}\nА ХОТИТЕ ПРОДАТЬ {1}\nСДЕЛКА ЛИКВИДИРОВАНА\n";
	public static string STDis = "СДЕЛКА ЛИКВИДИРОВАНА\n";
	public static string STSell   = "УДАЛОСЬ ПРОДАТЬ ТОЛЬКО {0}\n";
	public static string STBuy   = "УДАЛОСЬ СКУПИТЬ ТОЛЬКО {0}\n";

	public static string ACC0 = "ИГРАЯ НА БИРЖЕ ВЫ НЕПРАВИЛЬНО ОФОРМЛЯЛИ СДЕЛКИ.\nУЩЕРБ СОСТАВИЛ {0}\nЗАВЕДИТЕ ХОРОШЕНР МАКЛЕРА\n";
	public static string ACC1 = "ЗАНИМАЯСЬ БИЗНЕСОМ ВЫ ЗАБЫВАЕТЕ О ЗДОРОВЬЕ.\nПРЕБЫВАНИЕ В БОЛЬНИЦЕ ОБОШЛОСЬ ВАМ В {0}\n";
	public static string ACC2 = "ФИРМА MICROSOFT ВОЗБУДИЛА ПРОТИВ ВАС СУДЕБНОЕ ДЕЛО\nНАНИМАЕТЕ АДВОКАТА ?\nEГО УСЛУГИ ОБОЙДУТСЯ В {0}\n";
	public static string ACC3 = "ВАС ШАНТАЖИРУЮТ, ВЫМОГАЯ {0}\nСОЧУСТВУЕМ, НО ВЫ ВОВРЕМЯ НЕ ОБРАТИЛИСЬ\nК УСЛУГАМ СЫСКНОГО БЮРО.\nПРИДЁТСЯ ПЛАТИТЬ.\n";
	public static string ACC4 = "ВАС ОБЧИСТИЛИ, ЗАБРАВ ВСЕ ЦЕННЫЕ БУМАГИ.\nУБЫТОК СОСТАВИЛ {0}\nУЧТИТЕ НА БУДУЩЕЕ\n";
	public static string ACCW = "ВЫ ВЫИГРАЛИ ДЕЛО.\nСОВЕТУЕМ ИМЕТЬ СОБСТВЕННОГО ЮРИСТА\n";

	public static string[] VAS  = new string[5]{"БИЗНЕСМЕН      ", "ЛИДЕР ПРОФСОЮЗА", "ШЕРИФ          ", "СЕНАТОР        ", "ПРЕЗИДЕНТ      "};
	public static string[] VAS2 = new string[5]{"", "ЛИДЕРА ПРОФСОЮЗА\nМУСОРЩИКОВ", "ШЕРИФА", "СЕНАТОРА", "ПРЕЗИДЕНТА"};
	public static string[] VBS  = new string[5]{"1-КВАРТИРУ     ", "2-МАШИНУ       ", "3-ВИЛЛУ        ", "4-ЯХТУ         ", "5-САМОЛЁТ      "};
	public static string[] VCS  = new string[5]{"1-МАКЛЕРА      ", "2-ВРАЧА        ", "3-АДВОКАТА     ", "4-ДЕТЕКТИВА    ", "5-ОХРАНУ       "};
	public static string[] VDS  = new string[5]{"1-БАР          ", "2-РЕСТОРАН     ", "3-МАГАЗИН      ", "4-ОТЕЛЬ        ", "5-ЗАВОД        "};
	public static string[] VDF  = new string[5]{"1-ISHTIRA      ", "2-SWEMA        ", "3-VOLVO        ", "4-I.B.M.       ", "5-KORWET       "};
	public static string[] VDG  = new string[5]{"1-ПРЕФЕРАНС    ", "2-РУЛЕТКУ      ", "3-ЛЮБОВНИЦУ    ", "4-БАНКЕТ       ", "5-КРУИЗ        "};

	public static string GameHello = "\nРАЗВЛЕКАЯСЬ С УМОМ, МОЖНО ПОЛУЧИТЬ И БАРЫШ\n\nМОЖЕМ\t\tЗАТРАТЫ  ВОЗМОЖНЫЙ  ВЕРОЯТНОСТЬ\nПРЕДЛОЖИТЬ\t\t\t\tДОХОД\tУСПЕХА\n";
	public static string GameNo = "ВАМ ГОВОРИЛИ УЖЕ, ЧТО ВЫ   Ж М О Т ?\n";
	public static string GameCh = "ЧЕГО ИЗВОЛИТЕ - С ? ";
	public static string GameLoose = "ВАМ НЕ ВЕЗЁТ - ОДНИ РАСХОДЫ.\n";
	public static string GameWin = "НА ЭТОТ РАЗ ВАМ ПОВЕЗЛО. ДОВОЛЬНЫ ?\n";
	public static string GameOver = "ГОСПОДА!\nМЕЖДУНАРОДНЫЙ БИЗНЕС ПОНЁС НЕВОСПОЛНИМУЮ УТРАТУ.\nНА {0} ГОДУ ЖИЗНИ\nЗАКОНЧИЛАСЬ ДЕЯТЕЛЬНОСТЬ НАШЕГО КОЛЛЕГИ\n";
	public static string GameRet = "ПРИМИТЕ СОБОЛЕЗНОВАНИЯ.\nНАЧНЁМ СНАЧАЛА ? ";

	public static string NYHello = "ЗАКОНЧИЛСЯ {0} ГОД\nПОДВЕДЁМ ИТОГИ\n";
	public static string NYPay = "БУДЕМ ОПЛАЧИВАТЬ РАСХОДЫ ? ";
	public static string NYFl = "ЗА БРОДЯЖНИЧЕСТВО ВЫ ОШТРАФОВАНЫ НА СУММУ {0}\n";
	public static string NYNA = "ВЫ ОШТРАФОВАНЫ НАЛОГОВЫМ УПРАВЛЕНИЕМ НА СУММУ {0}\nЗА  Ж М О Т Н И Ч Е С Т В О.\n";
	public static string NYNal = "У ВАС ДЕФИЦИТ СРЕДСТВ {0}\n";
	public static string NYSellS = "ВАШИ АКЦИИ РАСПРОДАНЫ НА СУММУ {0}\n";
	public static string NYSellF = "ВАШЕ ИМУЩЕСТВО ПОШЛО С МОЛОТКА.\n УДАЛОСЬ ВЫРУЧИТЬ {0}\nПОДЧИНЁННЫЕ ВАС БРОСИЛИ !\n ДОИГРАЛИСЬ ? ";
	public static string NYJail = "\nЗА ДОЛГИ И НЕОПЛАЧЕННЫЕ СЧЕТА ВЫ ПЕРЕЕЗЖАЕТЕ НА\nКАЗЁННУЮ КВАРТИРУ В FORT LEVECK СРОКОМ НА {0}\nГДЕ ВАС БУДУТ ПЫТАТЬ РЕКЛАМОЙ\nПОСИДИМ ? ";
	public static string NYDead = "\nЗА ОГРОМНЫЕ ДОЛГИ ВЫ ПРОИГОВОРЕНЫ К ВЫСШЕЙ МЕРЕ\n";
	public static string NYNew = "НАСТУПИЛ НОВЫЙ {0} ГОД\n";

	public static string NYKr = "С ВАС УДЕРЖАЛИ КРЕДИТ И ПРОЦЕНТЫ\nВ РАЗМЕРЕ {0}\n";
	public static string NYSg = "ВЫ УДАЧНО ССУДИЛИ ДЕНЬГИ. БАРЫШ СОСТАВИЛ {0}\n";
	public static string NYSf = "АФЕРА С ССУДОЙ НЕ УДАЛАСЬ.\n";

	public static string CrashCar = "ВЫ ПОПАЛИ В АВТОКАТАСТРОФУ И ЧУДОМ ОСТАЛИСЬ ЖИВЫ!\nОСТАНКИ АВТОМОБИЛЯ МОЖЕТЕ ВЫБРОСИТЬ\n";
	public static string CrashAcc = "ВАМ НАНЕСЁН УЩЕРБ В РАЗМЕРЕ {0}\n";
	public static string CrashEns = "СТРАХОВАЯ КОМПАНИЯ ВЫПЛАТИЛА ВАМ {0}\n";
	public static string CrashVil = "СИОНИСТЫ ПОДОЖГЛИ ВАШУ ВИЛЛУ!\n";
	public static string CrashYac = "ЭКСТРЕМИСТЫ УВЕЛИ И ЗАТОПИЛИ ВАШУ ЯХТУ\n";
	public static string CrashFly = "ВЫ НА СВОЁМ САМОЛЁТЕ ПОПАЛИ В АВИАКАТАСТРОФУ.\nНАМ ОЧЕНЬ ЖАЛЬ НО . . .\n\n";

	public static string MENU = " ЧТО ВАС ИНТЕРЕСУЕТ ?\n1-ФИНАНСОВОЕ ПОЛОЖЕНИЕ\n2-ОБЩЕСТВЕННОЕ ПОЛОЖЕНИЕ\n3-ЛИЧНОЕ ИМУЩЕСТВО\n4-ВАШИ ПОДЧИНЁННЫЕ\n5-ВАШ БИЗНЕС\n6-БИРЖЕВЫЕ ОПЕРАЦИИ\n7-БАНКОВСКИЕ ОПЕРАЦИИ\n8-РАЗВЛЕЧЕНИЯ\n? ";
	public static string cashe = "НАЛИЧНЫЕ СРЕДСТВА {0}\n";
	public static string stat = "В АКЦИЯХ\t\t{0}\nСЧЁТ В БАНКЕ\t{1}\nНЕДВИЖИМОСТЬ\t{2}\nГОДОВОЙ ДОХОД\t{3}\nРАСХОД ЗА ГОД\t{4}\n";
	public static string total = "ВЕСЬ ВАШ КАПИТАЛ СОСТАВЛЯЕТ {0}\n";
	public static string Expenses = "         РАСХОДЫ НА СОДЕРЖАНИЕ -45% в ГОД\n";
	public static string NotEnought = "ВЫ НЕ ИМЕЕТЕ ТРЕБУЕМОГО КОЛИЧЕСТВА НАЛИЧНЫХ\nСРЕДСТВ. ЗА ПОПЫТКУ МОШЕННИЧЕСТВА\nВЫ ОШТРАФОВАНЫ НА - {0}\n\n";
	public static string AnotherOne = "ЕЩЁ ОДНА СДЕЛКА ? ";

	public static string Bankrote = "БАНК - БАНКРОТ !\nВАМ ВЫПЛАЧЕНА КОМПЕНСАЦИЯ -{0}\n";
	public static string BankHello = "БАНК ПРИВЕТСТВУЕТ КЛИЕНТА, ЧЕГО ЖЕЛАЕТЕ?\n\n1-ЗАСТРАХОВАТЬ ИМУЩЕСТВО\n2-СДЕЛАТЬ ВКЛАД\n3-СНЯТЬ СО СЧЁТА\n";
	public static string BankGivKr = "4-ДАТЬ ССУДУ\n";
	public static string BankGetKr = "5-ПОЛУЧИТЬ КРЕДИТ\n";
	public static string BankAkk   = "СЧЁТ В БАНКЕ {0}\n";
	public static string BankCost  = "СТОИМОСТЬ ОПЕРАЦИИ -5%\n";
	public static string BankSCost = "ГОДОВОЙ СТРАХОВОЙ ВЗНОС -5%\n";
	public static string BankGet   = "СКОЛЬКО БЕРЁТЕ ? ";
	public static string BankSet   = "СКОЛЬКО ПОМЕЩАЕТЕ ? ";
	public static string BankPerc  = "ГАРАНТИРУЕМ {0}% ГОДОВОГО ДОХОДА\n";
	public static string BankStr   = "МОЖНО ЗАСТРАХОВАТЬ ТО, ЧТО ";
	public static string BankStr2  = "ОФОРМЛЯЕМ СТРАХОВКУ ? ";
	public static string BankStr3  = "РЕАЛЬНО МЫ ОЦЕНИВАЕМ \n";
	public static string BankStr4  = "ЧТО СТРАХУЕТЕ ? ";
	public static string BankStr5  = "НА СУММУ ? ";
	public static string BankStr6  = "НА КАКОЙ СРОК ? ";
	public static string BankStr7  = "ЕЩЁ ОДНА СТРАХОВКА ? ";

	public static string SsudHello = "СНАЧАЛА ДОГОВОРИМСЯ ОБ УСЛОВИЯХ \n\n";
	public static string SsudMany  = "СКОЛЬКО ХОТИТЕ ДАТЬ ? ";
	public static string SsudProc  = "ПОД КАКИЕ ПРОЦЕНТЫ ? ";
	public static string SsudOff   = "ШАНС ЗАРАБОТАТЬ - {0}\nПО РУКАМ ? ";

	public static string KredNo    = "БАНКРОТАМ НА ДАЁМ\n";
	public static string KredHello = "СО ВСЕМИ ПОТРОХАМИ ВЫ СТОИТЕ {0}\nДАЁМ НА СРОК НЕ БОЛЕЕ 5 ЛЕТ\nСКОЛЬКО ПРОСИТЕ ? ";
	public static string KredMany  = "НА КАКОЙ СРОК ? ";
	public static string KredPerc  = "ДАЁМ ПОД {0} ПРОЦЕНТОВ\nБЕРЁТЕ ? ";
	public static string KredWhen  = "ЗАПОМНИТЕ ВРЕМЯ РАСПЛАТЫ - {0} ГОД\n";

	public static string[] canSell  = new string[9]
	{
		 ""
		,""
		,""
		,"ВЫ МОЖЕТЕ ПРОДАТЬ\t\tСТОИМОСТЬ\n"	//Имущество
		,"ВЫ МОЖЕТЕ УВОЛИТЬ\t\tЗАПЛАТИВ НЕУСТОЙКУ\n"		// Сотрудники
		,"ВЫ МОЖЕТЕ ПРОДАТЬ\tСТОИМОСТЬ\tГОДОВОЙ ДОХОД\n"	//Бизнес
		,""
		,""
		,""
	};

	public static string[] canBuy  = new string[9] 
	{
		 ""
		,""
		,"СКОЛЬКО ? "
		,"ВЫ МОЖЕТЕ КУПИТЬ -\t\tЦЕНА\n" // Имущество
		,"ВЫ МОЖЕТЕ НАНЯТЬ\t\tУПЛАТИВ В ГОД\n"	// Сотрудники
		,"ВЫ МОЖЕТЕ КУПИТЬ\tСТОИМОСТЬ\tДОХОД\n" //Бизнес
		,""
		,""
		,""
	};

	public static string[] Dont = new string[9]
	{
		 "ОЧУМЕЛИ ? ЧИТАТЬ УМЕЕТЕ ?\n"
		,"АКЦИЙ БОЛЬШЕ В ПРОДАЖЕ НЕТ\n"
		,"СРЕДИ ДЕЛОВЫХ ЛЮДЕЙ ДУРАКОВ МАЛО\n"
		,"НЕ ГЛУПИТЕ\n"	// Имущество
		,"У ВАС ПРОГРЕССИРУЮЩИЙ СКЛЕРОЗ !!!"
		,"ВЫ СПЯТИЛИ ?\n"	// БИЗНЕС
		,""
		,"СДУРЕЛИ?\n"
		,""
	};

	public static string[] NothingSell = new string[9]
	{
		 ""
		,""
		,""
		,"ВАМ НЕЧЕГО ПРОДАВАТЬ\nЖУЛИКОВ У НАС НАКАЗЫВАЮТ\n"
		,"ВЫ РЕХНУЛИСЬ ?\n"
		,"ВАМ НЕЧЕГО ПРОДАВАТЬ\nЖУЛИКОВ У НАС НАКАЗЫВАЮТ\n"
		,""
		,""
		,""
	};


	public static string[] WillBuy = new string[9]
	{
		 ""
		,""
		,""
		,"ПОКУПАЕТЕ ? "
		,"НАНИМАЕТЕ ? "
		,"ПОКУПАЕТЕ ? "
		,"ПОКУПАЕТЕ ? "
		,""
		,"ГУЛЯЕМ ? "
	};

	public static string[] WillSell = new string[9]
	{
		 ""
		,""
		,""
		,"ПРОДАЁТЕ ? "
		,"УВОЛЬНЯЕТЕ ? "
		,"ПРОДАЁТЕ ? "
		,"ПРОДАЁТЕ ? "
		,""
		,""
	};

	public static string[] What = new string[9]
	{
		""
		,""
		,""
		,"ЧТО ? "
		,"КОГО ? "
		,"ЧТО ? "
		,"КАКОЙ ФИРМЫ ? "
		,""
		,""
	};

	public static void Init()
	{
		if (Application.systemLanguage == SystemLanguage.Russian
		    || Application.systemLanguage == SystemLanguage.Ukrainian
		    || Application.systemLanguage == SystemLanguage.Belarusian)
		{
			 retry = "?ПОВТОРИТЕ ВВОД\n";
			
			 gettime = "ВВЕДИТЕ ВРЕМЯ (ЧАС.МИН)? ";
			 getyear = "ВВЕДИТЕ ГОД? ";
			 getlev = "ВВЕДИТЕ КАТЕГОРИЮ СЛОЖНОСТИ 0,1,2, И Т.Д.? ";
			
			 hello  = "    ПОЗДРАВЛЯЕМ ВАС С ПРИБЫТИЕМ\n        В НАШУ СТРАНУ,\n";
			 hello2 = "    ГДЕ КАЖДЫЙ МОЖЕТ СТАТЬ ПРЕЗИДЕНТОМ!!!\n";
			 canbe = "МОЖНО ДАЖЕ ПРЕДСТАВИТЬ, ЧТО . . .\n";
			 have = "ВЫ ИМЕЕТЕ -\n";
			 payfor = "ОПЛАЧИВАЕТЕ УСЛУГИ-\n";
			 bill2 = "И СЧЁТ В БАНКЕ - 1 000 000&,НО ПОКА ЭТО МЕЧТЫ.\nРЕАЛИЗУЙТЕ ИХ\n";
			 age = " ВАШ ВОЗРАСТ ? ";
			 mummy = "ЗРЯ ЕХАЛИ, В МУМИЯХ НЕ НУЖДАЕМСЯ\n";
			 young = "МЛАДЕНЦАМ У НАС ДЕЛАТЬ НЕЧЕГО\n";
			 cash = "СКОЛЬКО ИМЕЕТЕ НАЛИЧНЫМИ ? ";
			 toomuch = "ГДЕ ВЫ СТОЛЬКО ДОБЫЛИ. ПО НАШИМ ДАННЫМ У ВАС\n";
			
			 you = "В НАСТОЯЩЕЕ ВРЕМЯ ВЫ - ";
			 VybNot = "СОЖАЛЕЕМ, НО В ЭТОМ ГОДУ ВЫБОРЫ НЕ ПРОВОДЯТСЯ\n";
			 VybHello = "В ЭТОМ ГОДУ ВЫ МОЖЕТЕ ПРИНЯТЬ УЧАСТИЕ В ВЫБОРАХ\n\nЕСТЬ\tПРЕДВЫБОНАЯ КАМПАНИЯ\tВЕРОЯТНОСТЬ\nМЕСТО\t\tОБОЙДЁТСЯ В -\t\tУСПЕХА В %\n\n";
			 Vyb = "УЧАСТВУЕТЕ В ВЫБОРАХ ? ";
			 VybDis = "ТРУС НЕ ИГРАЕТ В ХОККЕЙ.\nCЛЕДУЮЩИЕ ВЫБОРЫ ЧЕРЕЗ 2 ГОДА\n";
			 VybFail = "ВЫ НЕ ПОЛЬЗУЕТЕСЬ ПОПУЛЯРНОСТЬЮ ИЗБИРАТЕТЕЙ\nВАС ПРОКАТИЛИ. ВЫ НАБРАЛИ ТОЛЬКО {0}% ГОЛОСОВ\n";
			 VybWin = "ПОЗДРАВЛЯЕМ ВАС. ТЕПЕРЬ ВЫ - ";
			 VybFin = "ВЫ ДОСТИГЛИ НЕВОЗМОЖНОГО !!!\nБОЛЬШЕ ЖЕЛАТЬ НЕЧЕГО\n";
			 VybWas    = "У ВАС СКЛЕРОЗ.\nВ ЭТОМ ГОДУ ВЫ УЖЕ УЧАСТВОВАЛИ В ВЫБОРАХ\n";
			
			 STClose = "БИРЖА ЗАКРЫТА НА КАНИКУЛЫ\n";
			 STHello = "ТЕКУЩЕЕ ПОЛОЖЕНИЕ БИРЖЕВЫХ ДЕЛ -\n\nАКЦИИ\nФИРМЫ\t\t   ИМЕЕТЕ\tКУРС\tДИВИДЕНТЫ %\n\n";
			 STHavent = "ВЫ ИМЕЕТЕ {0}\nА ХОТИТЕ ПРОДАТЬ {1}\nСДЕЛКА ЛИКВИДИРОВАНА\n";
			 STDis = "СДЕЛКА ЛИКВИДИРОВАНА\n";
			 STSell   = "УДАЛОСЬ ПРОДАТЬ ТОЛЬКО {0}\n";
			 STBuy   = "УДАЛОСЬ СКУПИТЬ ТОЛЬКО {0}\n";
			
			 ACC0 = "ИГРАЯ НА БИРЖЕ ВЫ НЕПРАВИЛЬНО ОФОРМЛЯЛИ СДЕЛКИ.\nУЩЕРБ СОСТАВИЛ {0}\nЗАВЕДИТЕ ХОРОШЕНР МАКЛЕРА\n";
			 ACC1 = "ЗАНИМАЯСЬ БИЗНЕСОМ ВЫ ЗАБЫВАЕТЕ О ЗДОРОВЬЕ.\nПРЕБЫВАНИЕ В БОЛЬНИЦЕ ОБОШЛОСЬ ВАМ В {0}\n";
			 ACC2 = "ФИРМА MICROSOFT ВОЗБУДИЛА ПРОТИВ ВАС СУДЕБНОЕ ДЕЛО\nНАНИМАЕТЕ АДВОКАТА ?\nEГО УСЛУГИ ОБОЙДУТСЯ В {0}\n";
			 ACC3 = "ВАС ШАНТАЖИРУЮТ, ВЫМОГАЯ {0}\nСОЧУСТВУЕМ, НО ВЫ ВОВРЕМЯ НЕ ОБРАТИЛИСЬ\nК УСЛУГАМ СЫСКНОГО БЮРО.\nПРИДЁТСЯ ПЛАТИТЬ.\n";
			 ACC4 = "ВАС ОБЧИСТИЛИ, ЗАБРАВ ВСЕ ЦЕННЫЕ БУМАГИ.\nУБЫТОК СОСТАВИЛ {0}\nУЧТИТЕ НА БУДУЩЕЕ\n";
			 ACCW = "ВЫ ВЫИГРАЛИ ДЕЛО.\nСОВЕТУЕМ ИМЕТЬ СОБСТВЕННОГО ЮРИСТА\n";
			
			 VAS  = new string[5]{"БИЗНЕСМЕН      ", "ЛИДЕР ПРОФСОЮЗА", "ШЕРИФ          ", "СЕНАТОР        ", "ПРЕЗИДЕНТ      "};
			 VAS2 = new string[5]{"", "ЛИДЕРА ПРОФСОЮЗА\nМУСОРЩИКОВ", "ШЕРИФА", "СЕНАТОРА", "ПРЕЗИДЕНТА"};
			 VBS  = new string[5]{"1-КВАРТИРУ     ", "2-МАШИНУ       ", "3-ВИЛЛУ        ", "4-ЯХТУ         ", "5-САМОЛЁТ      "};
			 VCS  = new string[5]{"1-МАКЛЕРА      ", "2-ВРАЧА        ", "3-АДВОКАТА     ", "4-ДЕТЕКТИВА    ", "5-ОХРАНУ       "};
			 VDS  = new string[5]{"1-БАР          ", "2-РЕСТОРАН     ", "3-МАГАЗИН      ", "4-ОТЕЛЬ        ", "5-ЗАВОД        "};
			 VDF  = new string[5]{"1-ISHTIRA      ", "2-SWEMA        ", "3-VOLVO        ", "4-I.B.M.       ", "5-KORWET       "};
			 VDG  = new string[5]{"1-ПРЕФЕРАНС    ", "2-РУЛЕТКУ      ", "3-ЛЮБОВНИЦУ    ", "4-БАНКЕТ       ", "5-КРУИЗ        "};
			
			 GameHello = "\nРАЗВЛЕКАЯСЬ С УМОМ, МОЖНО ПОЛУЧИТЬ И БАРЫШ\n\nМОЖЕМ\t\tЗАТРАТЫ  ВОЗМОЖНЫЙ  ВЕРОЯТНОСТЬ\nПРЕДЛОЖИТЬ\t\t\t\tДОХОД\tУСПЕХА\n";
			 GameNo = "ВАМ ГОВОРИЛИ УЖЕ, ЧТО ВЫ   Ж М О Т ?\n";
			 GameCh = "ЧЕГО ИЗВОЛИТЕ - С ? ";
			 GameLoose = "ВАМ НЕ ВЕЗЁТ - ОДНИ РАСХОДЫ.\n";
			 GameWin = "НА ЭТОТ РАЗ ВАМ ПОВЕЗЛО. ДОВОЛЬНЫ ?\n";
			 GameOver = "ГОСПОДА!\nМЕЖДУНАРОДНЫЙ БИЗНЕС ПОНЁС НЕВОСПОЛНИМУЮ УТРАТУ.\nНА {0} ГОДУ ЖИЗНИ\nЗАКОНЧИЛАСЬ ДЕЯТЕЛЬНОСТЬ НАШЕГО КОЛЛЕГИ\n";
			 GameRet = "ПРИМИТЕ СОБОЛЕЗНОВАНИЯ.\nНАЧНЁМ СНАЧАЛА ? ";
			
			 NYHello = "ЗАКОНЧИЛСЯ {0} ГОД\nПОДВЕДЁМ ИТОГИ\n";
			 NYPay = "БУДЕМ ОПЛАЧИВАТЬ РАСХОДЫ ? ";
			 NYFl = "ЗА БРОДЯЖНИЧЕСТВО ВЫ ОШТРАФОВАНЫ НА СУММУ {0}\n";
			 NYNA = "ВЫ ОШТРАФОВАНЫ НАЛОГОВЫМ УПРАВЛЕНИЕМ НА СУММУ {0}\nЗА  Ж М О Т Н И Ч Е С Т В О.\n";
			 NYNal = "У ВАС ДЕФИЦИТ СРЕДСТВ {0}\n";
			 NYSellS = "ВАШИ АКЦИИ РАСПРОДАНЫ НА СУММУ {0}\n";
			 NYSellF = "ВАШЕ ИМУЩЕСТВО ПОШЛО С МОЛОТКА.\n УДАЛОСЬ ВЫРУЧИТЬ {0}\nПОДЧИНЁННЫЕ ВАС БРОСИЛИ !\n ДОИГРАЛИСЬ ? ";
			 NYJail = "\nЗА ДОЛГИ И НЕОПЛАЧЕННЫЕ СЧЕТА ВЫ ПЕРЕЕЗЖАЕТЕ НА\nКАЗЁННУЮ КВАРТИРУ В FORT LEVECK СРОКОМ НА {0}\nГДЕ ВАС БУДУТ ПЫТАТЬ РЕКЛАМОЙ\nПОСИДИМ ? ";
			 NYDead = "\nЗА ОГРОМНЫЕ ДОЛГИ ВЫ ПРОИГОВОРЕНЫ К ВЫСШЕЙ МЕРЕ\n";
			 NYNew = "НАСТУПИЛ НОВЫЙ {0} ГОД\n";
			
			 NYKr = "С ВАС УДЕРЖАЛИ КРЕДИТ И ПРОЦЕНТЫ\nВ РАЗМЕРЕ {0}\n";
			 NYSg = "ВЫ УДАЧНО ССУДИЛИ ДЕНЬГИ. БАРЫШ СОСТАВИЛ {0}\n";
			 NYSf = "АФЕРА С ССУДОЙ НЕ УДАЛАСЬ.\n";
			
			 CrashCar = "ВЫ ПОПАЛИ В АВТОКАТАСТРОФУ И ЧУДОМ ОСТАЛИСЬ ЖИВЫ!\nОСТАНКИ АВТОМОБИЛЯ МОЖЕТЕ ВЫБРОСИТЬ\n";
			 CrashAcc = "ВАМ НАНЕСЁН УЩЕРБ В РАЗМЕРЕ {0}\n";
			 CrashEns = "СТРАХОВАЯ КОМПАНИЯ ВЫПЛАТИЛА ВАМ {0}\n";
			 CrashVil = "СИОНИСТЫ ПОДОЖГЛИ ВАШУ ВИЛЛУ!\n";
			 CrashYac = "ЭКСТРЕМИСТЫ УВЕЛИ И ЗАТОПИЛИ ВАШУ ЯХТУ\n";
			 CrashFly = "ВЫ НА СВОЁМ САМОЛЁТЕ ПОПАЛИ В АВИАКАТАСТРОФУ.\nНАМ ОЧЕНЬ ЖАЛЬ НО . . .\n\n";
			
			 MENU = " ЧТО ВАС ИНТЕРЕСУЕТ ?\n1-ФИНАНСОВОЕ ПОЛОЖЕНИЕ\n2-ОБЩЕСТВЕННОЕ ПОЛОЖЕНИЕ\n3-ЛИЧНОЕ ИМУЩЕСТВО\n4-ВАШИ ПОДЧИНЁННЫЕ\n5-ВАШ БИЗНЕС\n6-БИРЖЕВЫЕ ОПЕРАЦИИ\n7-БАНКОВСКИЕ ОПЕРАЦИИ\n8-РАЗВЛЕЧЕНИЯ\n? ";
			 cashe = "НАЛИЧНЫЕ СРЕДСТВА {0}\n";
			 stat = "В АКЦИЯХ\t\t{0}\nСЧЁТ В БАНКЕ\t{1}\nНЕДВИЖИМОСТЬ\t{2}\nГОДОВОЙ ДОХОД\t{3}\nРАСХОД ЗА ГОД\t{4}\n";
			 total = "ВЕСЬ ВАШ КАПИТАЛ СОСТАВЛЯЕТ {0}\n";
			 Expenses = "         РАСХОДЫ НА СОДЕРЖАНИЕ -45% в ГОД\n";
			 NotEnought = "ВЫ НЕ ИМЕЕТЕ ТРЕБУЕМОГО КОЛИЧЕСТВА НАЛИЧНЫХ\nСРЕДСТВ. ЗА ПОПЫТКУ МОШЕННИЧЕСТВА\nВЫ ОШТРАФОВАНЫ НА - {0}\n\n";
			 AnotherOne = "ЕЩЁ ОДНА СДЕЛКА ? ";
			
			 Bankrote = "БАНК - БАНКРОТ !\nВАМ ВЫПЛАЧЕНА КОМПЕНСАЦИЯ -{0}\n";
			 BankHello = "БАНК ПРИВЕТСТВУЕТ КЛИЕНТА, ЧЕГО ЖЕЛАЕТЕ?\n\n1-ЗАСТРАХОВАТЬ ИМУЩЕСТВО\n2-СДЕЛАТЬ ВКЛАД\n3-СНЯТЬ СО СЧЁТА\n";
			 BankGivKr = "4-ДАТЬ ССУДУ\n";
			 BankGetKr = "5-ПОЛУЧИТЬ КРЕДИТ\n";
			 BankAkk   = "СЧЁТ В БАНКЕ {0}\n";
			 BankCost  = "СТОИМОСТЬ ОПЕРАЦИИ -5%\n";
			 BankSCost = "ГОДОВОЙ СТРАХОВОЙ ВЗНОС -5%\n";
			 BankGet   = "СКОЛЬКО БЕРЁТЕ ? ";
			 BankSet   = "СКОЛЬКО ПОМЕЩАЕТЕ ? ";
			 BankPerc  = "ГАРАНТИРУЕМ {0}% ГОДОВОГО ДОХОДА\n";
			 BankStr   = "МОЖНО ЗАСТРАХОВАТЬ ТО, ЧТО ";
			 BankStr2  = "ОФОРМЛЯЕМ СТРАХОВКУ ? ";
			 BankStr3  = "РЕАЛЬНО МЫ ОЦЕНИВАЕМ \n";
			 BankStr4  = "ЧТО СТРАХУЕТЕ ? ";
			 BankStr5  = "НА СУММУ ? ";
			 BankStr6  = "НА КАКОЙ СРОК ? ";
			 BankStr7  = "ЕЩЁ ОДНА СТРАХОВКА ? ";
			
			 SsudHello = "СНАЧАЛА ДОГОВОРИМСЯ ОБ УСЛОВИЯХ \n\n";
			 SsudMany  = "СКОЛЬКО ХОТИТЕ ДАТЬ ? ";
			 SsudProc  = "ПОД КАКИЕ ПРОЦЕНТЫ ? ";
			 SsudOff   = "ШАНС ЗАРАБОТАТЬ - {0}\nПО РУКАМ ? ";
			
			 KredNo    = "БАНКРОТАМ НА ДАЁМ\n";
			 KredHello = "СО ВСЕМИ ПОТРОХАМИ ВЫ СТОИТЕ {0}\nДАЁМ НА СРОК НЕ БОЛЕЕ 5 ЛЕТ\nСКОЛЬКО ПРОСИТЕ ? ";
			 KredMany  = "НА КАКОЙ СРОК ? ";
			 KredPerc  = "ДАЁМ ПОД {0} ПРОЦЕНТОВ\nБЕРЁТЕ ? ";
			 KredWhen  = "ЗАПОМНИТЕ ВРЕМЯ РАСПЛАТЫ - {0} ГОД\n";
			
			 canSell  = new string[9]
			{
				""
				,""
				,""
				,"ВЫ МОЖЕТЕ ПРОДАТЬ\t\tСТОИМОСТЬ\n"	//Имущество
				,"ВЫ МОЖЕТЕ УВОЛИТЬ\t\tЗАПЛАТИВ НЕУСТОЙКУ\n"		// Сотрудники
				,"ВЫ МОЖЕТЕ ПРОДАТЬ\tСТОИМОСТЬ\tГОДОВОЙ ДОХОД\n"	//Бизнес
				,""
				,""
				,""
			};
			
			 canBuy  = new string[9] 
			{
				""
				,""
				,"СКОЛЬКО ? "
				,"ВЫ МОЖЕТЕ КУПИТЬ -\t\tЦЕНА\n" // Имущество
				,"ВЫ МОЖЕТЕ НАНЯТЬ\t\tУПЛАТИВ В ГОД\n"	// Сотрудники
				,"ВЫ МОЖЕТЕ КУПИТЬ\tСТОИМОСТЬ\tДОХОД\n" //Бизнес
				,""
				,""
				,""
			};
			
			 Dont = new string[9]
			{
				"ОЧУМЕЛИ ? ЧИТАТЬ УМЕЕТЕ ?\n"
				,"АКЦИЙ БОЛЬШЕ В ПРОДАЖЕ НЕТ\n"
				,"СРЕДИ ДЕЛОВЫХ ЛЮДЕЙ ДУРАКОВ МАЛО\n"
				,"НЕ ГЛУПИТЕ\n"	// Имущество
				,"У ВАС ПРОГРЕССИРУЮЩИЙ СКЛЕРОЗ !!!"
				,"ВЫ СПЯТИЛИ ?\n"	// БИЗНЕС
				,""
				,"СДУРЕЛИ?\n"
				,""
			};
			
			 NothingSell = new string[9]
			{
				""
				,""
				,""
				,"ВАМ НЕЧЕГО ПРОДАВАТЬ\nЖУЛИКОВ У НАС НАКАЗЫВАЮТ\n"
				,"ВЫ РЕХНУЛИСЬ ?\n"
				,"ВАМ НЕЧЕГО ПРОДАВАТЬ\nЖУЛИКОВ У НАС НАКАЗЫВАЮТ\n"
				,""
				,""
				,""
			};
			
			
			 WillBuy = new string[9]
			{
				""
				,""
				,""
				,"ПОКУПАЕТЕ ? "
				,"НАНИМАЕТЕ ? "
				,"ПОКУПАЕТЕ ? "
				,"ПОКУПАЕТЕ ? "
				,""
				,"ГУЛЯЕМ ? "
			};
			
			 WillSell = new string[9]
			{
				""
				,""
				,""
				,"ПРОДАЁТЕ ? "
				,"УВОЛЬНЯЕТЕ ? "
				,"ПРОДАЁТЕ ? "
				,"ПРОДАЁТЕ ? "
				,""
				,""
			};
			
			 What = new string[9]
			{
				""
				,""
				,""
				,"ЧТО ? "
				,"КОГО ? "
				,"ЧТО ? "
				,"КАКОЙ ФИРМЫ ? "
				,""
				,""
			};

		}
	}

	public static string timerize(string pTag, float pTime)
	{
		int a = (int)pTime;
		string b = ((int)((pTime - a) * 100)).ToString();
		if (b.Length == 1)
			b = "0"+b;

		return pTag.Replace("%a",a.ToString()).Replace("%b",b);
	}

}
