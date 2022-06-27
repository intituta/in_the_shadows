using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class get_audio : MonoBehaviour {
	public GameObject music;
	void Start () {
		music =  GameObject.FindWithTag("music");
	gameObject.GetComponent<Slider>().onValueChanged.AddListener(delegate {change_volume(); });
	}
	public void change_volume()
	{
		 music.GetComponent<AudioSource>().volume =  gameObject.GetComponent<Slider>().value;
	}
	
}
