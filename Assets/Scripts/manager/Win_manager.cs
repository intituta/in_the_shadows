using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Win_manager : MonoBehaviour {

	public GameObject [] validation_obj_ray;
    public GameObject [] validation_obj_box;

    public GameObject victory_menue;
    bool victory = false;
    void Update()
    {
        foreach (GameObject obj in validation_obj_ray)
        {
            if (obj.GetComponent<Raycast_test>().valide == false)
                return;
        }
        foreach (GameObject obj in validation_obj_box)
        {
            if (obj.GetComponent<valide_stay_triger>().valide == false)
                return;
        }
        if (victory == false)
        {
            victory_menue.SetActive(true);
            victory =  true;
        }
    }
}
