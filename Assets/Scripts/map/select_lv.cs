using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class select_lv : MonoBehaviour {
	public GameObject plane;
	public GameObject GameObject_lv;
	public int lv_load;
	void Start ()
	{
		plane  =  GameObject.Find("plane");
		GameObject_lv =  GameObject.Find("map_pos");
	}
	public void Load_Level()
	{
		
		SceneManager.LoadScene("lv_" + lv_load.ToString());
	}
	public void change_diection()
	{
		plane.GetComponent<mov_to>().pos_end = GameObject_lv.transform.GetChild(lv_load).gameObject;
		plane.GetComponent<mov_to>().Reset_moving_value();
		plane.GetComponent<Get_set_info>().reaload(lv_load);
	}

}
