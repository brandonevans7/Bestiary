using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnClick : MonoBehaviour {

	public AudioClip sound;
	private AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource>();
	}
		
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		audio.PlayOneShot(sound, 0.9F);
	}
}
