using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnClick : MonoBehaviour {

	public AudioClip sound;
	private AudioSource auds;

	void Start() {
		auds = GetComponent<AudioSource>();
	}
		
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		auds.PlayOneShot(sound, 0.9F);
	}
}
