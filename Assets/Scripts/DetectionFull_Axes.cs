using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionFull_Axes : MonoBehaviour {
	public Vector3 target;
	public Vector3 marge;

	Vector3 actual;

	void Update () {
		actual = transform.eulerAngles;
		print(actual);
		if (target.x < actual.x + marge.x && target.x > actual.x - marge.x)
			print("victory _x");
		if( target.y < actual.y + marge.y && target.y > actual.y - marge.y)
			print("victory _y");

		if(target.z < actual.z + marge.z && target.z > actual.z - marge.z)
			print("victory _z");

	}
}
