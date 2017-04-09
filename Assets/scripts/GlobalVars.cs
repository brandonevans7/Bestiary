using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVars: MonoBehaviour  {

	public static int gold;

	public static bool investMode = false;

	// Use this for initialization
	void Start()
	{
		if(PlayerPrefs.HasKey("gold"))
		{
		gold = PlayerPrefs.GetInt ("gold");
		}

	}

	void OnDestroy()
	{
		PlayerPrefs.SetInt ("gold", gold);
	}

}
