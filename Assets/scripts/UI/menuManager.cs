using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuManager : MonoBehaviour {


	private Animator ani;

	public GameObject topMenu;

	void Awake()
	{
		ani = this.GetComponent<Animator> ();
	}



	public virtual void NextItem()
	{

	}

	public virtual void LastItem()
	{


	}

	public virtual void CloseMenu()
	{

		ani.SetTrigger ("down");

		if (topMenu != null) {
			topMenu.GetComponent<Animator> ().SetTrigger ("up");
		}
			
//		this.gameObject.SetActive (false);
	}
		
}
