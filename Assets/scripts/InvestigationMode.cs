using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvestigationMode : MonoBehaviour {

//	public bool InvestModeOn = false;
	public BeastManager bm;
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
			dark.transform.position = new Vector3 (dark.transform.position.x, dark.transform.position.y, -25f);

			//for all the beasts in beast manager
			for (int x = 0; x < bm.Beast.Length; x++) {
				//if a beast is able to be investigated
				if (bm.Beast [x].investThisTime == false) {
					Debug.Log (bm.Beast [x].name + " can be investigated");
					bm.Beast [x].magic = true;
					bm.Beast [x].transform.position = new Vector3 (bm.Beast [x].transform.position.x, bm.Beast [x].transform.position.y, (bm.Beast [x].transform.position.z - 30f));
				}
			}



		} else {
			if (GlobalVars.investMode == true) {
				GlobalVars.investMode = false;
				dark.SetActive (false);

				for (int x = 0; x < bm.Beast.Length; x++) {

					bm.Beast [x].magic = false;
					bm.Beast [x].transform.position = new Vector3 (bm.Beast [x].transform.position.x, bm.Beast [x].transform.position.y, bm.Beast [x].transform.position.y);
				}
			}
		}
	}
}
