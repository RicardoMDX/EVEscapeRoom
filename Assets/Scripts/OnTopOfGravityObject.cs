using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTopOfGravityObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            if (hit.transform.name=="GravityCube")
            {
                this.GetComponent<Rigidbody>().isKinematic = false;
            }
            else
            {
                this.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }
}
