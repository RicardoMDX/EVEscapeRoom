using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Rigidbody rgbody;
    private bool b_enabled = true;

    public float gravityScale = 2.0f;
    public static float globalGravity = -9.81f;

    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (b_enabled)
        {
            Vector3 gravity = globalGravity * gravityScale * Vector3.up;
            rgbody.AddForce(gravity, ForceMode.Acceleration);
        }
    }

    private void Disable()
    {
        b_enabled = false;
    }

    void Enable()
    {
        b_enabled = true;
    }
}
