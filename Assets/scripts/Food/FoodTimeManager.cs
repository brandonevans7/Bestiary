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


//	public Text message;

	// Use this for initialization
	void Awake () {

		if(PlayerPrefs.HasKey("foodExpiration"))
		{
			foodExpire = new DateTime( long.Parse( PlayerPrefs.GetString( "foodExpiration" ) ) );
		}
		if(PlayerPrefs.HasKey("foodType"))
		{

			foodType = PlayerPrefs.GetString ("foodType");

		}
		currentTime = DateTime.Now;
		CheckIfFoodOut();


	}

//	void Start () {
//
//		if(PlayerPrefs.HasKey("foodExpiration"))
//		{
//			foodExpire = new DateTime( long.Parse( PlayerPrefs.GetString( "foodExpiration" ) ) );
//		}
//		if(PlayerPrefs.HasKey("foodType"))
//		{
//
//			foodType = PlayerPrefs.GetString ("foodType");
//
//		}
//		currentTime = DateTime.Now;
//		CheckIfFoodOut();
//
//
//	}


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
		PlayerPrefs.SetString("foodExpiration", "" + foodExpire.Ticks);
//		Debug.Log (foodExpire.Ticks);
		PlayerPrefs.SetString("foodType", foodType.ToString());
		PlayerPrefs.Save();
	}

	void CheckIfFoodOut()
	{
		if (foodExpire > currentTime) 
		{

			DisplayFood (foodType);

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
		Debug.Log ("new expire " + foodExpire);

		DisplayFood (type); 

		PlayerPrefs.SetString("foodExpiration", "" + foodExpire.Ticks);
//		Debug.Log (foodExpire.Ticks);
		PlayerPrefs.SetString("foodType", foodType.ToString());
		PlayerPrefs.Save();

	}
	public void DisplayFood(string type)
	{
		foodOut = true;

		foodType = type;

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
