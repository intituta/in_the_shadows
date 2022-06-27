using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_to : MonoBehaviour {
	public GameObject pos_b;
	public GameObject pos_end;
	public Vector4 speed;
	public float distance;
	public bool go_up =  true;
	public bool go_down =  false;
	public GameObject play_m;
	public void Reset_moving_value()
	{
		distance =  Vector2.Distance(new Vector2(this.transform.position.x,transform.position.z) ,new Vector2(pos_end.transform.position.x,pos_end.transform.position.z)) / 4;
		speed.x = distance/2;
		speed.y =  distance/2;
		speed.z =  distance;
		speed.w =  distance/10;
	} 
	void Start () {
		this.transform.position = pos_b.transform.position;
		Reset_moving_value();
		
	}
	void Retake_altitude()
	{
		float distace2d =Vector2.Distance(new Vector2(this.transform.position.x,transform.position.z) ,new Vector2(pos_end.transform.position.x,pos_end.transform.position.z));

		if (speed.z > this.transform.position.y && distace2d > distance)
			go_up = true;
	}
	void Update () {
		if(speed == Vector4.zero)
		{
			speed.y =10;
			speed.w = 4;
			speed.z = 4;
			go_up = true;
		}
		Vector3 pos_a = this.transform.position;
		if(go_up == true)
		{
			this.transform.position = new Vector3(pos_a.x,pos_a.y + (speed.y * Time.deltaTime),pos_a.z);
		}
		if(speed.z <= this.transform.position.y)
			go_up = false;
		Retake_altitude();
		float distace2d =Vector2.Distance(new Vector2(this.transform.position.x,transform.position.z) ,new Vector2(pos_end.transform.position.x,pos_end.transform.position.z));
		if (distance >= distace2d)
			go_down =  true;
		if(speed.w >= this.transform.position.y)
			go_down = false;
		if(go_down == true)
			this.transform.position = new Vector3(pos_a.x,pos_a.y  - (speed.y * Time.deltaTime),pos_a.z);
		
		if(distace2d >= 0.2)
		{
			Vector3 target_pos =  new Vector3(pos_end.transform.position.x,transform.position.y,pos_end.transform.position.z);
			transform.LookAt(target_pos);
			Debug.DrawRay(this.transform.position ,this.transform.forward,Color.red,50);
			this.transform.position += this.transform.forward * Time.deltaTime * speed.x;
		}
	}
}
