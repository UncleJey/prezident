using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Фаза операции
/// </summary>
public enum Phase : byte
{
	 None = 0
	,Pre = 1
	,Sym = 2
	,After = 3
}

[System.Serializable]
public class TextTask
{
	public string text;
	public float beforePause = 0f;
	public float symPause = 0f;
	public float afterPause = 0f;
	public System.Action WhenDone;

	public float curTimer = 0;
	public Phase phase = Phase.None;
	public int symNo = 0;
}

public class TextWriter : MonoBehaviour 
{
	public static bool ready = true;
	public Text text;
	public Image MainPanel;
	public int maxWidth = 50;

	static TextWriter instance;
	static Queue<TextTask> tasks = new Queue<TextTask> ();
	static TextTask task = null;

	public float carSpeed = 0.5f;
	public string carrage;
	bool _showCarr = false;
	float _carTimer = 0f;

	/// <summary>
	/// Показывать ли каретку
	/// </summary>
	public static bool ShowCarrage
	{
		get
		{
			return instance._showCarr;
		}
		set
		{
			instance._showCarr = value;
			if (!value)
				instance._carTimer = -instance.carSpeed;
			else
				instance._carTimer = instance.carSpeed;
		}
	}

	void showCar(bool pShow = true)
	{
		bool have = text.text.Contains (carrage);
		if (pShow && !have && _showCarr)
			text.text += carrage;
		else if ((!pShow && have) || !_showCarr)
			text.text = text.text.Replace (carrage, "");
	}

	void Awake()
	{
		instance = this;
		ready = true;
	}

	void Update () 
	{
		_carTimer -= Time.deltaTime;
		if (_carTimer < -carSpeed)
			_carTimer = carSpeed;
		showCar (_carTimer > 0);

		if (task == null && tasks.Count > 0)
		{
			task = tasks.Dequeue ();
			ready = false;
		}

		if (task != null)
		{
			task.curTimer -= Time.deltaTime;
			if (task.curTimer > 0)
				return;

			switch (task.phase)
			{
				case Phase.None: // Стартуем
					task.phase = Phase.Pre;
					task.curTimer = task.beforePause;
				break;
				case Phase.Pre:
					task.phase = Phase.Sym;
					task.curTimer = task.symPause;
					task.symNo = 0;
				break;
				case Phase.Sym:
					showCar(false);
					_carTimer = 0;
					while (task.curTimer < 0)
					{
						if (task.text.Length <= task.symNo)
						{
							task.phase = Phase.After;
							task.curTimer = task.afterPause;
							//text.text += "\n";
						}
						else
						{
							char c = task.text[task.symNo];
							text.text += c;
							if (largeLine) // Перенос на новую строку
							{
								c = '\n';
								text.text += c;
							}

							task.symNo ++;
							if (c == '\n')
								CheckLines();
						}
						task.curTimer += task.symPause;
					}
				break;
				default:
					if (task.WhenDone != null)
						task.WhenDone.Invoke();
					task = null;
					if (tasks.Count < 1)
						ready = true;
				break;
			}
		}
	}

	/// <summary>
	/// Не велика ли последняя строка
	/// </summary>
	bool largeLine
	{
		get
		{
			string[] lns = text.text.Split('\n');
			return lns[lns.Length-1].Length > maxWidth;
		}
	}
	/// <summary>
	/// Показать текст
	/// </summary>
	public static void ShowMsg(
		 string pText
		,float pWaitBefore = 0
		,float pSymPause = 0.005f
		,float pWaitAfter = 0
		,System.Action WhenDone = null)
	{
		if (pText == "<")
			DelLast ();
		else
		{
			TextTask task = new TextTask ();
			task.beforePause = pWaitBefore;
			task.symPause = pSymPause;
			task.afterPause = pWaitAfter;
			task.text = pText;
			task.WhenDone = WhenDone;
			tasks.Enqueue (task);
		}
	}


	/// <summary>
	/// Цвет фона
	/// </summary>
	public static Color BGColor
	{
		get
		{
			return instance.MainPanel.color;
		}
		set
		{
			instance.MainPanel.color = value;
		}
	}

	/// <summary>
	/// Очистить текст
	/// </summary>
	public static void Clear()
	{
		instance.text.text = "";
	}

	public static void DelLast()
	{
		instance.showCar (false);
		if (instance.text.text.Length > 0)
			instance.text.text = instance.text.text.Remove (instance.text.text.Length - 1);
	}

	void CheckLines()
	{
		string[] strs = instance.text.text.Split ('\n');
		if (strs.Length > 16)
		{
			string str = ""; int mcnt = strs.Length;
			for (int i = strs.Length - 16; i< mcnt; i++)
				str += strs[i]+ (i<mcnt-1?"\n":"");
			instance.text.text = str;
		}
	}
}

