using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoovOBJ : MonoBehaviour {

	Vector3 screenPos;

	 public float speed;

	 public Vector3 poitR;

	 public bool object_select =  true;

	void Update () {
		
		if (object_select == false)
			return;
		float modifier;
		if(Input.GetMouseButton(0))
		{
			screenPos = Camera.main.WorldToScreenPoint(transform.position);
			if (Input.mousePosition.x >= screenPos.x)
				modifier = speed;
			else
				modifier = -speed;
			transform.RotateAround(transform.position,Vector3.up,modifier * Time.deltaTime);
		}
		else if(Input.GetMouseButton(1))
		{
			screenPos = Camera.main.WorldToScreenPoint(transform.position);
			if (Input.mousePosition.y >= screenPos.y)
				modifier = speed;
			else
				modifier = -speed;
			transform.RotateAround(transform.position,Vector3.right,modifier * Time.deltaTime);

		}

	}
}
