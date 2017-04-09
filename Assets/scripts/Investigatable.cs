﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Investigatable : MonoBehaviour {

	private BeastInfo bi;

	// Use this for initialization
	void Start () {
		bi = GetComponent<BeastInfo> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
		if (GlobalVars.investMode == true) {
			bi.knowledgeLevel++;
		}
	}
}
