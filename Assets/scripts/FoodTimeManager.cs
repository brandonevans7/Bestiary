using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class FoodTimeManager : MonoBehaviour {
	

	public bool foodOut = false;

	public float foodDurration = 5.0f;

	public DateTime foodExpire;

	public DateTime currentTime = DateTime.Now;


	public SpriteRenderer spriteR;
	public Sprite newSprite;
	Sprite oldSprite;

	public Text message;

	// Use this for initialization
	void Start () {
		
		spriteR = GetComponentInChildren<SpriteRenderer>();
		oldSprite = spriteR.sprite;

		if(PlayerPrefs.HasKey("foodExpire"))
		{
			long temp = Convert.ToInt64(PlayerPrefs.GetString("foodExpire"));
			foodExpire = DateTime.FromBinary(temp);
		}
		currentTime = DateTime.Now;
		CheckIfFoodOut();
	}

	// Update is called once per frame
	void Update () {
		currentTime = DateTime.Now;

		CheckIfFoodOut ();

	}
	void OnMouseDown()  
	{
		if (!foodOut) 
		{
			foodExpire = currentTime.AddSeconds (foodDurration);
		}

	}
	void OnDestroy()
	{
		PlayerPrefs.SetString("foodExpire", foodExpire.ToBinary().ToString());
	}

	void CheckIfFoodOut()
	{
		if (foodExpire > currentTime) 
		{

			foodOut = true;
			spriteR.sprite = newSprite;
			message.text = "now come back later to see if anything shows up";

		}
		else
		{
			spriteR.sprite = oldSprite;
			foodOut = false;
		}
	}
		
}
