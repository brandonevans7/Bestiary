using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeastManager : MonoBehaviour {

	public GameObject[] Beast;

	public GameObject Food;



	private bool foodOut;

	// Use this for initialization
	void Start () {
		// first set all creatures inactive
		for (int x = 0; x < Beast.Length; x++ )
		{
			Beast[x].SetActive(false);
		}

		// check if the food was out 
		FoodTimeManager fm = Food.GetComponent<FoodTimeManager>();

		if (fm.foodOut) 
		{
			Debug.Log ("food is out");
			int rand = Random.Range (1, Beast.Length);
//			Beast [rand].SetActive (true);
						for (int x = 0; x < rand; x++ )
						{
							Beast[x].SetActive(true);
						}

			//			for (int x = 0; x < Beast.Length; x++ )
			//			{
			//				Beast[x].SetActive(true);
			//			}
		}

	}
	
	// Update is called once per frame
	void Update () {

	}

}
