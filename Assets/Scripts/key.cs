using UnityEngine;
using System.Collections;

public class key : MonoBehaviour 
{
	public string keyName;
	Animator a;

	void Awake()
	{
		a = GetComponent<Animator> ();
	}

	public void down()
	{
		a.Play ("down");
	}

	public void up()
	{
		a.Play ("up");
	}
}
