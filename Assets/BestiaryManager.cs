using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestiaryManager : menuManager {

	public BeastManager bm;

	private int currentNum;

	private GameObject currentBeast;

	// Use this for initialization
	void Start () {

		currentNum = 0;

		CreateBeast ();
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void CreateBeast()
	{
//		currentBeast = (GameObject)Instantiate(bm.Beast[currentNum].beast,new Vector3(0.00f,-2.89f,-11),Quaternion.identity);
//
//		currentBeast = (GameObject)Instantiate(bm.Beast[currentNum].beast,new Vector3(0.00f,-2.89f,-11),Quaternion.identity);
//		currentBeast.transform.parent = gameObject.transform;
	}

}
