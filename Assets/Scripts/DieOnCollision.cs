using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GravityObject")
        {
            if (collision.relativeVelocity.magnitude >= 5)
            {
                //Player dies
                Debug.Log(collision.relativeVelocity.magnitude);
                Debug.Log("player died");
            }
            else
            {
                Debug.Log(collision.relativeVelocity.magnitude);
                Debug.Log("player did not die");
            }
        }
    }
}
