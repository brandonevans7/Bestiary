﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVars: MonoBehaviour  {

	public static int gold;

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
