using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuManager : MonoBehaviour {

	public void NextItem()
	{

	}

	public void LastItem()
	{


	}

	public virtual void CloseMenu()
	{
		this.gameObject.SetActive (false);
	}

	public void CreateItem()
	{
	
	}
}
