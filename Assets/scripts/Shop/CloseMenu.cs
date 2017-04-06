using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMenu : MonoBehaviour {

	public menuManager mm;

	void OnMouseDown()
	{
		mm.CloseMenu ();
	}
}
