using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5Manager : MonoBehaviour
{
    public int i_PressurePlates=0;
    public GameObject go_Hologram;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (i_PressurePlates == 4)
        {
            go_Hologram.SetActive(true);
        }
    }
}
