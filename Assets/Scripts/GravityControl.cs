using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Physics.gravity = new Vector3(0, -10f, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Physics.gravity = new Vector3(0, 10f, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Physics.gravity = new Vector3(10f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Physics.gravity = new Vector3(-10f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Physics.gravity = new Vector3(0, 0, 10f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Physics.gravity = new Vector3(0, 0, -10f);
        }
    }
}
