using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum food {kibble, crystal}

public class BeastInfo : MonoBehaviour {


	public int rarity;
	public string info1;
	public string info2;
	public string info3;
	public food favFood;
	public GameObject beast;


	// Use this for initialization
	void Start () {
		beast = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
