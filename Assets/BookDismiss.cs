using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookDismiss : ClickToDismiss {
	

	public GameObject dark;

	public override void Start () {
		animator = GetComponent<Animator> ();

		dark.SetActive(true);
	}

	public override void OnMouseDown()
	{
		animator.SetTrigger ("dismiss");
		dark.SetActive(false);
	}

	void Finished()
	{
		Destroy (gameObject, 5);
	}
}
