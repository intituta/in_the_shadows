using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_m : MonoBehaviour {
	public GameObject main;
	public GameObject optn;

	void Start () {
		optn.SetActive(false);
		main.SetActive(true);
		
	}

	public void activate_optn()
	{
		if(optn.activeInHierarchy)
			optn.SetActive(false);
		else
			optn.SetActive(true);


	}
	public void play()
	{
		PlayerPrefs.SetString("mode","Norm");

		SceneManager.LoadScene("Level_selector");

	}

	public void play_as_master()
	{
		PlayerPrefs.SetString("mode","DEV");

		SceneManager.LoadScene("Level_selector");
	}

public void appQuit()
	{
		PlayerPrefs.Save();
		print("quit");
		Application.Quit();
	}
}
