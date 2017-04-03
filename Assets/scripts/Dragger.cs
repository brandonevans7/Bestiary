using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour {

	private Vector3 screenPoint;
	private Vector3 offset;
	public bool draggable;

	void Start()
	{
		draggable = false;
	}

	void OnMouseDown()
	{
		if (draggable) {
			screenPoint = Camera.main.WorldToScreenPoint (transform.position);
			offset = transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	
		}

	}
	void OnMouseDrag()
	{
		if (draggable) {
			Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
			transform.position = curPosition;
		}
	}

}