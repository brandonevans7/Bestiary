using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuManager : MonoBehaviour {

	private Animator ani;

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
		this.gameObject.SetActive (false);
	}
		
}
