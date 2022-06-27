using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class option : MonoBehaviour {
    public GameObject opt;
	void Start () {
        opt = transform.Find("option").gameObject;
        opt.SetActive(false);
	}

    public void return_lv_selection()
    {
        SceneManager.LoadScene("Level_selector");
    }
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(opt.activeSelf == true)
            {
                opt.SetActive(false);
                return;
            }
            opt.SetActive(true);

        }
		
	}
}
