using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpritePicker : MonoBehaviour {

	public Sprite[] sprites;

	private SpriteRenderer sr;

	// Use this for initialization
	void Start () {

		sr = this.GetComponent<SpriteRenderer> ();
		int rand = Random.Range (0, sprites.Length);
		sr.sprite = sprites [rand];


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
