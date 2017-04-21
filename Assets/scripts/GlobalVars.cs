using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalVars: MonoBehaviour  {

	public static int gold;

	public static bool investMode = false;

	public static int beastsOut = 0;

	public static int beastsInvestigable = 0;



	// Use this for initialization
	void Awake()
	{
		if(PlayerPrefs.HasKey("gold"))
		{
			gold = PlayerPrefs.GetInt ("gold");
		}

	}

	void OnDestroy()
	{
		SaveGold ();
	}

	void OnApplicationPause()
	{
		SaveGold ();

	}
	void OnApplicationQuit()
	{
		SaveGold ();

	}
	public static void SaveGold(){
		PlayerPrefs.SetInt ("gold", gold);
		PlayerPrefs.Save();
	}

	void OnApplicationFocus(){
		Scene loadedLevel = SceneManager.GetActiveScene ();
		SceneManager.LoadScene (loadedLevel.buildIndex);
	}

}

