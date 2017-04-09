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

	public GameObject shop;
	public Sprite emptyFood;
	public Sprite kibbleFood;
	public Sprite crystalFood;

	public string foodType;



	public AudioClip sound;
	public AudioSource auds;


	public Text message;

	// Use this for initialization
	void Start () {

		if(PlayerPrefs.HasKey("foodExpire"))
		{
			long temp = Convert.ToInt64(PlayerPrefs.GetString("foodExpire"));
			foodExpire = DateTime.FromBinary(temp);
		}
		if(PlayerPrefs.HasKey("foodType"))
		{

			foodType = PlayerPrefs.GetString ("foodType");

		}
		currentTime = DateTime.Now;
		CheckIfFoodOut();

	}

	// Update is called once per frame
	void Update () {
		currentTime = DateTime.Now;

	}
	void OnMouseDown()  
	{
		shop.SetActive (true);

	}
	void OnDestroy()
	{
		PlayerPrefs.SetString("foodExpire", foodExpire.ToBinary().ToString());
		PlayerPrefs.SetString("foodType", foodType.ToString());
	}

	void CheckIfFoodOut()
	{
		if (foodExpire > currentTime) 
		{

			AddFood (foodType);

		}
		else
		{
			spriteR.sprite = emptyFood;
			foodOut = false;
		}
	}
	public void AddFood(string type)
	{
		foodExpire = currentTime.AddSeconds (foodDurration);
		foodOut = true;

		foodType = type;

		message.text = "now come back later to see if anything shows up";

		if (type == "kibble") 
		{
			spriteR.sprite = kibbleFood;
		}
		if (type == "crystal") 
		{
			spriteR.sprite = crystalFood;
		}
	}
		
}
