using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDisableParent : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		this.transform.parent.gameObject.SetActive (false);

	}
}