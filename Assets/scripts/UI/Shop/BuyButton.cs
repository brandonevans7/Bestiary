using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButton : MonoBehaviour {

	public shopManager sm;
	public Transform b;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		GameObject item = (GameObject)Instantiate(sm.currentitem,new Vector3(0.00f,-2.89f,-11),Quaternion.identity);
		item.GetComponent<Dragger> ().draggable = true;
		item.transform.SetParent(b);
		item.GetComponent<DepthByHeight>().DBH = true;
		sm.gameObject.SetActive (false);
		//disable button
		//set object to be draggable
	}
}
