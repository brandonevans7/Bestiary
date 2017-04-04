using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour {

	public bool draggable = false;

	private Vector3 offset;

	void OnMouseDown()
	{

		if (draggable) 
		{
			offset = gameObject.transform.position -
			Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10.0f));
		}
	}

	void OnMouseDrag()
	{
		if (draggable) 
		{
			Vector3 newPosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10.0f);
			transform.position = Camera.main.ScreenToWorldPoint (newPosition) + offset;
		}
	}
}
