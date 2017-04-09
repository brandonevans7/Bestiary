using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum food {kibble, crystal}

public class BeastInfo : MonoBehaviour {

	public string beastName;
	public int rarity;

	public DateTime expirationTime;
	public DateTime emptyTime; // this is bad.  should be based on spot.

	public string info1;
	public string info2;
	public string info3;

	public int pooAmt;
	public food favFood;
	public GameObject beast;


	// Use this for initialization
	void  Awake() {
		beast = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
