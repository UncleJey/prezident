using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour 
{
	public LayerMask groundMask;
//	bool touched = false;

	key _currentKey;

	key CurrentKey
	{
		get
		{
			return _currentKey;
		}
		set
		{
			if (_currentKey != null)
				_currentKey.up();
			if (value != null)
				value.down();

			_currentKey = value;
		}
	}

	string exKey = "";
	void CheckKBD()
	{
		string k = "";
		for (int i=0; i<10; i++)
		{
			if (Input.GetKeyDown(i.ToString()))
			{
				k = i.ToString();
				break;
			}
		}

		if (Input.GetKeyDown (KeyCode.Keypad0) || Input.GetKeyDown (KeyCode.Alpha0))
			k = "0";
		else if (Input.GetKeyDown (KeyCode.Keypad1) || Input.GetKeyDown (KeyCode.Alpha1))
			k = "1";
		else if (Input.GetKeyDown (KeyCode.Keypad2) || Input.GetKeyDown (KeyCode.Alpha2))
			k = "2";
		else if (Input.GetKeyDown (KeyCode.Keypad3) || Input.GetKeyDown (KeyCode.Alpha3))
			k = "3";
		else if (Input.GetKeyDown (KeyCode.Keypad4) || Input.GetKeyDown (KeyCode.Alpha4))
			k = "4";
		else if (Input.GetKeyDown (KeyCode.Keypad5) || Input.GetKeyDown (KeyCode.Alpha5))
			k = "5";
		else if (Input.GetKeyDown (KeyCode.Keypad6) || Input.GetKeyDown (KeyCode.Alpha6))
			k = "6";
		else if (Input.GetKeyDown (KeyCode.Keypad7) || Input.GetKeyDown (KeyCode.Alpha7))
			k = "7";
		else if (Input.GetKeyDown (KeyCode.Keypad8) || Input.GetKeyDown (KeyCode.Alpha8))
			k = "8";
		else if (Input.GetKeyDown (KeyCode.Keypad9) || Input.GetKeyDown (KeyCode.Alpha9))
			k = "9";

		else if (Input.GetKeyDown (KeyCode.Return))
			k = "R";
		else if (Input.GetKeyDown (KeyCode.Escape))
			k = "!";
		else if (Input.GetKeyDown (KeyCode.Backspace))
			k = "<";

		if (!string.IsNullOrEmpty(k))
		{
			if (exKey != k)
			{
				exKey = k;
				Pressed(k);
			}
		}
		else
			exKey = "";
	}


	void Update()
	{
		CheckKBD ();
		if (Input.touchCount > 0 || Input.GetMouseButton (0)) 
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 100, groundMask))
			{
				key k = (key) hit.collider.gameObject.GetComponent<key>();
				if (CurrentKey == null || k==null || k != CurrentKey)
				{
					if (k != null && TextWriter.ready)
						Pressed(k.keyName);
					CurrentKey = k;
				}
			}
		}
		else
			CurrentKey = null;
	}

	void Pressed(string pKey)
	{
		bool ret = false;
		if (pKey == "R" || pKey == "#13")
			ret = true;
		else if (pKey == "<")
		{
			if (str.Length > 0)
				str = str.Remove(str.Length-1);
		}
		else
			str += pKey;

		if (listener != null)
		{
			if (ret)
				TextWriter.ShowMsg("\n");
			else if (listener == null || needRet)
				if (" \n1234567890.<".IndexOf(pKey)>0)
					TextWriter.ShowMsg(pKey);

			if (!needRet || ret)
			{
				if (listener != null)
				{
					System.Action<string> l2 = listener;
					listener = null;
					TextWriter.ShowCarrage = false;
					l2(str);
					str = "";
				}
			}
		}

		if (ret)
			str = "";
	}

	static System.Action<string> listener = null;
	string str = "";
	static bool needRet = false;

	/// <summary>
	/// Запросить строку с устройства
	/// </summary>
	public static void GetStr(System.Action<string> pRet, bool pNeedRet = false)
	{
		listener = pRet;
		needRet = pNeedRet;
		if (listener != null)
			TextWriter.ShowCarrage = true;
	}
}
