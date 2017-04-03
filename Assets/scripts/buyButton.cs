using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyButton : MonoBehaviour {

	public shopManager sm;
	private Dragger d;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		d = sm.currentitem.GetComponent<Dragger> ();
		d.draggable = true;
	}
}
