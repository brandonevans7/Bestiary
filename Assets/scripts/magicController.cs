using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicController : MonoBehaviour {
	private BeastInfo bi;
	public GameObject part;

	// Use this for initialization
	void Start () {
		bi = this.GetComponent<BeastInfo> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (bi.magic == true) {
			part.SetActive (true);
		} else {
			part.SetActive (false);
		}
	}
}
