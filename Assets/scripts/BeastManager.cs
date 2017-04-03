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
		Debug.Log (Beast[0].rarity);
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

					CreatePoo (Beast [x].beast.transform.position.x, Beast [x].beast.transform.position.y);
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
			if (Beast [x].rarity == 1) {
				return true;
			} else {
				return false;
			}
		} else {
			return false;
		}


	}

	void CreatePoo(float x, float y)
	{

		Instantiate (Poo, new Vector3(x,y,y),Quaternion.identity);
	}

	void OnDestroy()
	{
		
	}
}
