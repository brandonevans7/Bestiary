using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArrow : MonoBehaviour {

	public menuManager mm;

	void OnMouseDown()
	{
		mm.NextItem ();
	}
}
