using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Victory_m : MonoBehaviour {

	public  int actual_lv;



	public void continue_b()
	{
		if(PlayerPrefs.GetString("mode") == "DEV")
		{

			SceneManager.LoadScene("Level_selector");
			return;
		}

		if(PlayerPrefs.GetInt("last_lv_unlock") == actual_lv)
		{
            PlayerPrefs.SetInt("need_play_annim", 1);

            PlayerPrefs.SetInt("last_lv_unlock",actual_lv +1);
			PlayerPrefs.Save();
			SceneManager.LoadScene("Level_selector");
		}
		else
			SceneManager.LoadScene("Level_selector");

	}

	public void  quit()
	{
		if(PlayerPrefs.GetString("mode") == "DEV")
		{
			SceneManager.LoadScene("main_menue");
			PlayerPrefs.Save();
			return;
		}
        if (PlayerPrefs.GetInt("last_lv_unlock") == actual_lv)
        {
            PlayerPrefs.SetInt("last_lv_unlock", actual_lv + 1);
            PlayerPrefs.SetInt("need_play_annim", 1);
        }
        PlayerPrefs.Save();
			SceneManager.LoadScene("main_menue");
	}
}
