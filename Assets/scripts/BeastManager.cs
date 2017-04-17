using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class BeastManager : MonoBehaviour {

	public BeastInfo[] Beast;

	public GameObject Food;
	public GameObject Poo;
	public Text instructions;


	public int maxRarity = 15;
	public int outLength = 30;
	public int emptyLength = 15;

	public bool foodOut;
	public int beastNum = 0;

	// Use this for initialization
	void Awake(){
		Screen.fullScreen = false;
		Screen.SetResolution (500, 888, false);
	}

	void Start () {
		InitBeasts ();		
		SaveActiveBeasts ();

	}
	
	// Update is called once per frame
	void Update () {

	}

	void InitBeasts()
	{
		// first set all creatures inactive
		for (int x = 0; x < Beast.Length; x++ )
		{
			Beast[x].beast.SetActive(false);

			if (PlayerPrefs.HasKey ("beast" + x + "investThisTime")) {
				if (PlayerPrefs.GetInt ("beast" + x + "investThisTime") == 1) {
					Beast[x].investThisTime = true;
				}
			}
			if(PlayerPrefs.HasKey("beast"+x+"expire"))
			{
//				long temp = Convert.ToInt64(PlayerPrefs.GetString("beast"+x+"expiration"));
				Beast[x].expirationTime =  new DateTime( long.Parse( PlayerPrefs.GetString( "beast"+x+"expire" ) ) );
			}
			if(PlayerPrefs.HasKey("beast"+x+"knowledge"))
			{
				Beast [x].knowledgeLevel = PlayerPrefs.GetInt ("beast" + x + "knowledge");
			}

			if(PlayerPrefs.HasKey("beast"+x+"spotEmpty"))
			{
//				long temp = Convert.ToInt64(PlayerPrefs.GetString("beast"+x+"empty"));
				Beast [x].emptyTime = new DateTime (long.Parse (PlayerPrefs.GetString ("beast" + x + "spotEmpty")));
			}

			//set beast active if beast can spawn
			if (BeastCanSpawn (x)) {
				Beast [x].beast.SetActive (true);
//				Beast [x].beast.GetComponent<DepthByHeight> ().DBH = true;

				GlobalVars.beastsOut++;

				//if expiration time is earlier than now, set expiration time.
				if (Beast [x].expirationTime < DateTime.Now) {
					Beast [x].expirationTime = DateTime.Now.AddSeconds (outLength);
					PlayerPrefs.SetString ("beast" + x + "expire", ""+Beast [x].expirationTime.Ticks);
					PlayerPrefs.Save();

//					Debug.Log (Beast[x].beastName + " expires at " + Beast [x].expirationTime);

				}
				
			}
				
			//check if a beast was previously active, but now expired.  if so, create a poo.
			if (CheckIfWasActive (x) && (Beast [x].expirationTime < DateTime.Now)) {

				CreatePoo (Beast [x].beast.transform.position.x, Beast [x].beast.transform.position.y,Beast[x].pooAmt);
			} 
		}

	}

	void SaveActiveBeasts()
	{
		for (int x = 0; x < Beast.Length; x++) 
		{ 
			if (Beast[x].beast.activeSelf)
			{
				PlayerPrefs.SetInt ("beast"+x+"active", 1);
				PlayerPrefs.Save();
			}
			else
			{
				PlayerPrefs.SetInt ("beast"+x+"active", 0);
				PlayerPrefs.Save();
			}

		}

	}


	bool CheckIfWasActive(int x)
	{
		if (PlayerPrefs.GetInt ("beast"+x+"active") == 1) {
			return true;
		} 
		else 
		{
			return false;
		}
	}

	bool FoodIsOut()
	{
		FoodTimeManager fm = Food.GetComponent<FoodTimeManager>();

		if (fm.foodOut) 
		{
			return true;
		} 
		else 
		{
			return false;
		}
	}

	bool BeastCanSpawn(int x)
	{
		//check if food is out
		if (FoodIsOut ()) {

			string foodType = Food.GetComponent<FoodTimeManager>().foodType;


			// if the beast's expiration time is later than now, it can spawn
			if (Beast [x].expirationTime > DateTime.Now) 
			{
				Beast [x].stillOut = true;
				return true;
			}

			// if the beast's emptytime is greater than now, it cannot spawn
			if (Beast [x].emptyTime > DateTime.Now) 
			{
				return false;
			}

			//spawn beast based on random rarity.  Anything has a shot 
			//CHANGE LATER!!!
			int rand = UnityEngine.Random.Range(1,maxRarity);

			if (Beast [x].rarity >= rand  && Beast[x].favFood.ToString() == foodType) 
			{
				Beast [x].investThisTime = false;

				GlobalVars.beastsInvestigable++;

				return true;
			} else {
				Beast [x].emptyTime = DateTime.Now.AddSeconds (emptyLength);
				PlayerPrefs.SetString ("beast" + x + "spotEmpty", ""+Beast [x].emptyTime.Ticks);
				PlayerPrefs.Save();
//				Debug.Log ( Beast[x].beastName + " will remain empty until " + Beast [x].emptyTime);
				return false;

			}
		} else {
			return false;
		}


	}

	void CreatePoo(float x, float y, int gold)
	{
		var obj = (GameObject)Instantiate (Poo, new Vector3(x,y,y),Quaternion.identity);
		obj.GetComponent<CollectGold> ().goldamt = gold;
		obj.GetComponent<SoundOnClick> ().auds = this.gameObject.GetComponent<AudioSource> ();

	}

	void OnDestroy()
	{
		for (int x = 0; x < Beast.Length; x++) {

			PlayerPrefs.SetInt ("beast" + x + "knowledge", Beast [x].knowledgeLevel);
			PlayerPrefs.Save ();

			if (Beast[x].investThisTime == true) {
				PlayerPrefs.SetInt ("beast" + x + "investThisTime", 1);
				PlayerPrefs.Save ();
			} else {
				PlayerPrefs.SetInt ("beast" + x + "investThisTime", 0);
				PlayerPrefs.Save ();
			}
		}
	}
	void OnApplicationQuit(){
		for (int x = 0; x < Beast.Length; x++) {

			PlayerPrefs.SetInt ("beast" + x + "knowledge", Beast [x].knowledgeLevel);
			PlayerPrefs.Save ();

			if (Beast[x].investThisTime == true) {
				PlayerPrefs.SetInt ("beast" + x + "investThisTime", 1);
				PlayerPrefs.Save ();
			} else {
				PlayerPrefs.SetInt ("beast" + x + "investThisTime", 0);
				PlayerPrefs.Save ();
			}
		}
	}
}
