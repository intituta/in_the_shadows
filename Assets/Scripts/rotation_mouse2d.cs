using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_mouse2d : MonoBehaviour {
	Vector3 screenPos;
	 public float speed;
	 public Vector3 poitR;
void Start () {
}
	void Update () {
		
		float modifier;
		if(Input.GetMouseButton(0))
		{
			print("click");
			screenPos = Camera.main.WorldToScreenPoint(transform.position);
			if (Input.mousePosition.x >= screenPos.x)
				modifier = speed;
			else
				modifier = -speed;
		transform.RotateAround(transform.position,Vector3.up,modifier * Time.deltaTime);
		}
	}
}
