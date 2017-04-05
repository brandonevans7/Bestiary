using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrow : MonoBehaviour {

	public shopManager sm;

	void OnMouseDown()
	{
		sm.LastItem ();
	}
}
