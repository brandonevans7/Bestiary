﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGold : MonoBehaviour {

	public int goldamt;


	// Use this for initialization
	void Start () {		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){


		GlobalVars.gold = GlobalVars.gold + goldamt;
		GlobalVars.SaveGold ();
		Destroy (gameObject);
	}
}
