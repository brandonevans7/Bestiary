using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestiaryManager : menuManager {

	public BeastManager bm;

	public int currentNum;

	private GameObject currentBeast;

//	public BeastInfo[] Beast;

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
		currentBeast = (GameObject)Instantiate(bm.Beast[currentNum].beast,new Vector3(0.00f,-2.89f,-11),Quaternion.identity);
//
//		currentBeast = (GameObject)Instantiate(Beast[currentNum].beast,new Vector3(0f,0f,-1),Quaternion.identity);
		currentBeast.SetActive (true);
		currentBeast.transform.parent = gameObject.transform;
		currentBeast.GetComponent<DepthByHeight> ().enabled = false;
		currentBeast.transform.position = new Vector3 (0f, 0f, -11);
	}

	public override void NextItem()
	{
		Destroy (currentBeast);
		currentNum = ((currentNum + 1) % bm.Beast.Length);

		CreateBeast ();
	}

	public override void LastItem()
	{
		Destroy (currentBeast);
		currentNum = ((currentNum + (bm.Beast.Length-1)) % bm.Beast.Length);

		CreateBeast ();

	}

}
