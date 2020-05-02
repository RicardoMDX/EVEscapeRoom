using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HologramTrigger : MonoBehaviour
{

    public GameObject go_textPlane;

    private bool bl_PlayerInRange=false, bl_BatteryGiven=false;
    private GameManager gm;
    private GameObject go_Player;
    private Vector3 v3_Direction;

    private Quaternion q_lookRotation;
    // Start is called before the first frame update
    void Start()
    {
        go_Player = GameObject.FindGameObjectWithTag("Player");
        gm = FindObjectOfType<Canvas>().GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(bl_PlayerInRange)
        {
            v3_Direction = (go_textPlane.transform.position - go_Player.transform.position);
            v3_Direction.y = 0;
            //create the rotation we need to be in to look at the target
            q_lookRotation = Quaternion.LookRotation(v3_Direction);

            //rotate us over time according to speed until we are in the required rotation
            go_textPlane.transform.rotation = Quaternion.Slerp(transform.rotation, q_lookRotation,1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            if(!bl_BatteryGiven)
            {
                gm.i_batteries++;
                bl_BatteryGiven = true;
            }
            go_textPlane.SetActive(true);
            bl_PlayerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            go_textPlane.SetActive(false);
            bl_PlayerInRange = false;
        }

    }
}
