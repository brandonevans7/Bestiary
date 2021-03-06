using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopManager : menuManager {

	public GameObject[] Items;
	public Text display;

	public GameObject currentitem;
	private int currentNum;

	// Use this for initialization
	void Start () {

		currentNum = 0;

		CreateItem ();

	}
	// Update is called once per frame
	void Update () {
		
		int itemcost = currentitem.GetComponent<ItemInfo> ().cost;
		display.text = "Price: " + itemcost.ToString ();

	}

	public override void NextItem()
	{

		Destroy (currentitem);
		currentNum = ((currentNum + 1) % Items.Length);

		CreateItem ();


	}

	public override void LastItem()
	{

		Destroy (currentitem);
		currentNum = ((currentNum + (Items.Length-1)) % Items.Length);

		CreateItem ();


	}

//	public override void CloseMenu()
//	{
//		Debug.Log ("close menu");
//		this.gameObject.SetActive (false);
//	}

	public void CreateItem()
	{
		currentitem = (GameObject)Instantiate(Items[currentNum],new Vector3(0.00f,-3.5f,-12),Quaternion.identity);
		currentitem.transform.parent = gameObject.transform;
	}
}
