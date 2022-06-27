using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_plane : MonoBehaviour {
	public GameObject plane;
	private Vector3 pos;
	void Start () {
		plane = GameObject.Find("plane");
	}
	void Update () {
		pos =  plane.transform.position;
		pos.y = this.transform.position.y;
		this.gameObject.transform.position = pos;
	}
}
