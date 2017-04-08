using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestiaryManager : menuManager {

	public BeastManager bm;

	public int currentNum;

	private GameObject currentBeast;

	public GameObject spot;

	public Text info1;
	public Text info2;
	public Text info3;

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
		currentBeast = (GameObject)Instantiate(bm.Beast[currentNum].beast);

		currentBeast.SetActive (true);
		currentBeast.transform.parent = gameObject.transform;
		currentBeast.GetComponent<DepthByHeight> ().enabled = false;

		float beastHeight = currentBeast.GetComponentInChildren<SpriteRenderer> ().bounds.size.y;
		float offsetY = spot.transform.position.y - (beastHeight / 2);
		currentBeast.transform.position = new Vector3 (spot.transform.position.x, offsetY, -11f);

		info1.text = bm.Beast [currentNum].info1.ToString();
		info2.text = bm.Beast [currentNum].info2.ToString();
		info3.text = bm.Beast [currentNum].info3.ToString();

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
