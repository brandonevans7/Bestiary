using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Investigatable : MonoBehaviour {

	private BeastInfo bi;

	public InvestigationMode im;

	// Use this for initialization
	void Start () {
		bi = GetComponent<BeastInfo> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
		if (GlobalVars.investMode == true && bi.investThisTime == false) {
			bi.knowledgeLevel++;
			GlobalVars.beastsInvestigable--;
			bi.magic = false;
			bi.investThisTime = true;
			im.InvestModeOff ();
		}
	}
}
