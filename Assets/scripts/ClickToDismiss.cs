using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDismiss : MonoBehaviour {

	public Animator animator;

	// Use this for initialization
	public virtual void Start () {
		animator = GetComponent<Animator> ();
	}

	public virtual void OnMouseDown()
	{
		animator.SetTrigger ("dismiss");
	}
}


