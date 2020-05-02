using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    public GameObject[] go_teleporters;

    private GameManager gm;
    private GameObject go_Player;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<Canvas>().GetComponent<GameManager>();
        go_Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            go_Player.SetActive(false);
            go_Player.transform.SetPositionAndRotation(go_teleporters[gm.i_batteries-1].transform.position, go_teleporters[gm.i_batteries-1].transform.rotation);
            go_Player.SetActive(true);
        }
    }
}
