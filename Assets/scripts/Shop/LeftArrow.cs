using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrow : MonoBehaviour {

	public menuManager mm;

	void OnMouseDown()
	{
		mm.LastItem ();
	}
}
