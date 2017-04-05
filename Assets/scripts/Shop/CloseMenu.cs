using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMenu : MonoBehaviour {

	public shopManager sm;

	void OnMouseDown()
	{
		sm.CloseMenu ();
	}
}
