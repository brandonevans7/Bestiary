using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class foodTimeDisplay : MonoBehaviour {

	public FoodTimeManager fm;
	private Text display;

	// Use this for initialization
	void Start () {
		display = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {

		TimeSpan remainingTime = (fm.foodExpire - fm.currentTime);
		if (remainingTime.TotalSeconds > 0) {
			string remainingTimeString = string.Format ("{0:D2}:{1:D2}:{2:D2}", remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds);
			display.text = "remaining time: \n" + remainingTimeString;
		} else {
			display.text = "remaining time: \n 0:00";
		}


		}
}
