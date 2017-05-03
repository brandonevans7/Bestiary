using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour {
	
	public SpriteRenderer spriteR;
	public Sprite newSprite;
	Sprite oldSprite;
	public bool toggle = false;

	public Text message;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey("foodOut"))
			{
			toggle = (PlayerPrefs.GetInt("foodOut") != 0);
			}
		spriteR = GetComponentInChildren<SpriteRenderer>();
		oldSprite = spriteR.sprite;
	}
	
	// Update is called once per frame
	void Update () {

		if (toggle == true) 
		{
			spriteR.sprite = newSprite;
			message.text = "now come back later to see if anything shows up";
		}
		else
		{
			spriteR.sprite = oldSprite;
		}
		
	}
	void OnMouseDown()  
	{
		if (toggle == false) 
		{
			spriteR.sprite = newSprite;
			toggle = true;
		}
		else
		{
			spriteR.sprite = oldSprite;
			toggle = false;
		}

	}
		
}
