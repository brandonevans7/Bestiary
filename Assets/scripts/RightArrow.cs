using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArrow : MonoBehaviour {

	public shopManager sm;

	void OnMouseDown()
	{
		sm.NextItem ();
	}
}
