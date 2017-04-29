using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookDismiss : ClickToDismiss {
	

	public GameObject dark;

	public GameObject menu;

	public override void Start () {
		animator = GetComponent<Animator> ();

		dark.SetActive(true);
		dark.GetComponentInChildren<ParticleSystem> ().Stop();
	}

	public override void OnMouseDown()
	{
		animator.SetTrigger ("dismiss");
		dark.SetActive(false);

	}

	void Finished()
	{
		Destroy (gameObject, 5);
		menu.SetActive (true);
	}
}
