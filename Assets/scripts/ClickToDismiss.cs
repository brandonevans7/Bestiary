using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDismiss : MonoBehaviour {

	protected Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}

	void OnMouseDown()
	{
		animator.SetTrigger ("dismiss");
	}
	// Update is called once per frame
	void Update () 
	{
		
	}
	void Finished()
	{
		Destroy (gameObject, 5);
	}
}
