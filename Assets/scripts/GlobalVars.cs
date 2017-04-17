using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVars: MonoBehaviour  {

	public static int gold;

	public static bool investMode = false;

	public static int beastsOut = 0;

	public static int beastsInvestigable = 0;

	// Use this for initialization
	void Awake()
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

	void OnApplicationPause(bool pauseStatus)
	{
		PlayerPrefs.Save();
	}
	void OnApplicationQuit()
	{
		PlayerPrefs.SetInt ("gold", gold);
		PlayerPrefs.Save();


	}
}

