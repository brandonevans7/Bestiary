using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvestigationMode : MonoBehaviour {

//	public bool InvestModeOn = false;
//	public BeastManager bm;
	public GameObject dark;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		if (GlobalVars.investMode == false) {
			GlobalVars.investMode = true;
			dark.SetActive (true);
			dark.transform.position = new Vector3 (dark.transform.position.x, dark.transform.position.y, 10f);
		} else {
			if (GlobalVars.investMode == true) {
				GlobalVars.investMode = false;
				dark.SetActive (false);
			}
		}
	}
}
