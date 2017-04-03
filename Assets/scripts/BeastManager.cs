using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeastManager : MonoBehaviour {

	public BeastInfo[] Beast;

	public GameObject Food;

	public GameObject Poo;

	private bool foodOut;

	// Use this for initialization
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

			//check if beasts can spawn
			Beast [x].beast.SetActive (BeastCanSpawn (x));

			//if beasts can't spawn
			if (BeastCanSpawn (x) == false) {

				//check if they were previously active
				if (CheckIfWasActive (x)) {

					CreatePoo (Beast [x].beast.transform.position.x, Beast [x].beast.transform.position.y,Beast[x].pooAmt);
				} 
			}
		}

	}

	void SaveActiveBeasts()
	{
		for (int x = 0; x < Beast.Length; x++) 
		{ 
			if (Beast[x].beast.activeSelf)
			{
				PlayerPrefs.SetInt ("beast"+x, 1);
			}
			else
			{
				PlayerPrefs.SetInt ("beast"+x, 0);
			}

		}

	}


	bool CheckIfWasActive(int x)
	{
		if (PlayerPrefs.GetInt ("beast" + x) == 1) {
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

			//spawn beast based on random rarity.  Anything has a shot 
			//CHANGE LATER!!!
			int rand = Random.Range(1,10);

//			Debug.Log ("beast rarity: " + Beast [x].rarity + " compared to " + rand); 

			if (Beast [x].rarity <= rand) {
				return true;
			} else {
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

//		Instantiate (Poo, new Vector3(x,y,y),Quaternion.identity);
	}

	void OnDestroy()
	{
		
	}
}
