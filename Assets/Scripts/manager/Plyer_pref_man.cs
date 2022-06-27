using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plyer_pref_man : MonoBehaviour {


	public void reset_play_pref()
	{
	 	PlayerPrefs.SetInt("last_lv_unlock",1);
	 	PlayerPrefs.SetInt("need_play_annim",1);
		PlayerPrefs.SetString("mode","Norm");
		PlayerPrefs.Save();
	}
	void Start () {
		if(PlayerPrefs.GetString("mode") == "")
		{
			reset_play_pref();
		}
		
		
	}
}
