using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalButton : MonoBehaviour {

	public FoodTimeManager foodBowl;

	public Text display;

	public int price = 50;

	// Use this for initialization
	void Start () {

		display.text = "price: " + price;
	
	}

	// Update is called once per frame
	void Update () 
	{
		if (GlobalVars.gold < price) {
			Color tmp = this.GetComponent<SpriteRenderer> ().color;
			tmp.a = .4f;
			this.GetComponent<SpriteRenderer>().color = tmp;

		}

	}
	void OnMouseDown () 
	{
		if (GlobalVars.gold > price) {
			foodBowl.AddFood ("crystal");
			this.transform.parent.gameObject.SetActive (false);
			GlobalVars.gold = GlobalVars.gold - price;
		}
	}
}
