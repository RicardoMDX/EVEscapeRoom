﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public Level3Manager lvl3Manager;
    public Level5Manager lvl5Manager;
    public int i_Level;
    public GameObject go_Destroy;

    private Light l_light;

    // Start is called before the first frame update
    void Start()
    {
        l_light = GetComponentInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ManipulationObject")
        {
            l_light.color = Color.green;
        }
        if (i_Level == 3)
        {
            lvl3Manager.i_PressurePlates++;
        }
        if (i_Level == 4)
        {
            GameObject.Destroy(go_Destroy);
        }
        if (i_Level == 5)
        {
            if(go_Destroy!=null)
            GameObject.Destroy(go_Destroy);
            lvl5Manager.i_PressurePlates++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ManipulationObject")
        {
            l_light.color = Color.red;
        }
        if (i_Level == 3)
        {
            lvl3Manager.i_PressurePlates--;
        }
        if (i_Level == 5)
        {
            lvl5Manager.i_PressurePlates--;
        }
    }
}
