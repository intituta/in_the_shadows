using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_manager : MonoBehaviour {
	public GameObject[] obj;
	public bool move_obj;

	public int actual = 0;

	public float ofcet_moove;
	void Start () {
		foreach(GameObject o in obj)
		{
			o.GetComponentInChildren<MoovOBJ>().object_select = false;
		}
		obj[actual].GetComponentInChildren<MoovOBJ>().object_select = true;
	}
	void Update () {
		if(Input.GetMouseButtonDown(2))
		{
			obj[actual].GetComponentInChildren<Renderer>().material.color =  Color.grey;
			obj[actual].GetComponentInChildren<MoovOBJ>().object_select = false;
			if (actual < obj.Length - 1)
			 	actual ++;
			else
				actual =  0;
			obj[actual].GetComponentInChildren<MoovOBJ>().object_select = true;
			obj[actual].GetComponentInChildren<Renderer>().material.color =  Color.white;
		}
		if(move_obj == false)
			return;
		if((Input.GetKey("left ctrl") || Input.GetKey("space") ))
		{
			obj[actual].GetComponentInChildren<MoovOBJ>().enabled = false;
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
       		if (Physics.Raycast(ray, out hit, Mathf.Infinity,LayerMask.GetMask("projection"))) //
			{
				obj[actual].transform.position = ray.GetPoint(ofcet_moove);
			}
			obj[actual].GetComponentInChildren<MoovOBJ>().enabled = true;
			
		}
	}
}
