using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instructionManager : MonoBehaviour {

	public Text instruction;
	private BeastManager bm;
	public FoodTimeManager fm;

	// Use this for initialization
	void Start () {
		bm = this.GetComponent<BeastManager> ();
		
	}
	
	// Update is called once per frame
	void Update () {

//		Debug.Log (GlobalVars.beastsOut + " number of beasts out");
//		Debug.Log (GlobalVars.beastsInvestigable + " number of beasts Investigable");
//		Debug.Log ("food out? " + fm.foodOut);

		if (GlobalVars.beastsOut <= 0 && fm.foodOut == true) 
		{
			instruction.text = "come back later to see if anything shows up";
		}
		if (GlobalVars.beastsOut > 0 && fm.foodOut == true) 
		{
			if (GlobalVars.beastsInvestigable > 0) {
				instruction.text = "try investigating the beasts";
			} else {
				instruction.text = "you learned what you can. Come back later";

			
			}

		}
	}
}
