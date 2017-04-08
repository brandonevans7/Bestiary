using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DisplayTime : MonoBehaviour {

	private string theTime;

	Text display;

	// Use this for initialization
	void Start () {
		
		display = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		theTime = DateTime.Now.ToString("hh:mm tt ");
		display.text = "Time: "+ theTime;

	}
}
