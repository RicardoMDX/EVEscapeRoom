using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Manager : MonoBehaviour
{
    public int i_PressurePlates=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (i_PressurePlates == 3)
        {
            this.gameObject.transform.position=Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y - 2, transform.position.z),Time.deltaTime/10);
        }
    }
}
