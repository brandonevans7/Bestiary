using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop : MonoBehaviour {

	public GameObject shop;
	private Animator parentAni;

	// Use this for initialization
	void Start () {
		parentAni = this.GetComponentInParent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		parentAni.SetTrigger ("down");

		shop.SetActive (true);
		shop.GetComponent<Animator>().SetTrigger("up");
//		shopManager sm = shop.GetComponent<shopManager> ();
	}
}
