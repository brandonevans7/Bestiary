using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayGold : MonoBehaviour {

	Text display;


	// Use this for initialization
	void Start () {
		display = GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {

		display.text = "Gold: "+ GlobalVars.gold;
		GlobalVars.SaveGold ();
		
	}
}
