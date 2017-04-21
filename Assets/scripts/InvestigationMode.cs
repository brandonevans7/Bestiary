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
		if (GlobalVars.investMode == false) 
		{
			InvestModeOn ();
		} else {
			InvestModeOff ();
		}
	}

	public void InvestModeOn ()
	{
		GlobalVars.investMode = true;
		dark.SetActive (true);
		dark.transform.position = new Vector3 (dark.transform.position.x, dark.transform.position.y, -25f);
		dark.GetComponentInChildren<ParticleSystem> ().Play();

		//for all the beasts in beast manager
		for (int x = 0; x < bm.Beast.Length; x++) 
		{
			//if a beast is able to be investigated
			if (bm.Beast [x].investThisTime == false) 
			{
				bm.Beast [x].magic = true;
				bm.Beast [x].GetComponent<DepthByHeight>().DBH = false;
				bm.Beast [x].transform.position = new Vector3 (bm.Beast [x].transform.position.x, bm.Beast [x].transform.position.y, (bm.Beast [x].transform.position.z - 30f));
			}
		}
	}

	public void InvestModeOff()
	{
		if (GlobalVars.investMode == true) 
		{
			GlobalVars.investMode = false;
			dark.SetActive (false);

			for (int x = 0; x < bm.Beast.Length; x++) 
			{

				bm.Beast [x].magic = false;
				bm.Beast [x].GetComponent<DepthByHeight>().DBH = true;
				bm.Beast [x].transform.position = new Vector3 (bm.Beast [x].transform.position.x, bm.Beast [x].transform.position.y, bm.Beast [x].transform.position.y);
			}
		}
	}
}
