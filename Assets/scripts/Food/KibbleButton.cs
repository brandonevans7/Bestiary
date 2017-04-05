using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KibbleButton : MonoBehaviour {

	public FoodTimeManager foodBowl;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown () 
	{
		foodBowl.AddFood ("kibble");
		this.transform.parent.gameObject.SetActive (false);
	}
}
