using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detection_basic : MonoBehaviour {

	public Vector3 target;
	
	Vector3 actual;

	void Update () {
		actual = transform.eulerAngles;
	}
}
