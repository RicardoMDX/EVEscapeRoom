using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckForItem : MonoBehaviour
{
    public GameObject go_ItemHolder;
    public Text txt_PickUpText;

    private bool b_HoldingItem=false;
    private new Camera camera;
    private GameObject lastObject=null;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (!b_HoldingItem)
        {
            if (Physics.Raycast(ray, out hit, 999f))
            {
                if (hit.transform.tag == "ManipulationObject")
                {
                    txt_PickUpText.enabled = true;
                    lastObject = hit.transform.gameObject;
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        go_ItemHolder.transform.position = lastObject.transform.position;
                        go_ItemHolder.transform.rotation = lastObject.transform.rotation;
                        lastObject.SendMessage("Disable");
                        lastObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                        lastObject.GetComponent<Rigidbody>().angularVelocity= Vector3.zero;
                        lastObject.transform.parent = go_ItemHolder.transform;
                        b_HoldingItem = true;
                        txt_PickUpText.enabled = false;
                    }
                }
                else if (lastObject != null)
                {
                    txt_PickUpText.enabled = false;
                }
                else
                {
                    txt_PickUpText.enabled = false;
                }
            }
            else if (lastObject != null)
            {
                txt_PickUpText.enabled = false;
            }
            else
            {
                txt_PickUpText.enabled = false;
            }
        }
        else
        {
            lastObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            lastObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            if (lastObject != null)
            {
                txt_PickUpText.enabled = false;
                Physics.Raycast(ray, out hit, 999f);
                if (Input.GetKeyDown(KeyCode.F) || hit.transform.gameObject != lastObject)
                {
                    lastObject.SendMessage("Enable");
                    lastObject.transform.parent = null;
                    b_HoldingItem = false;
                }
            }
            if(Input.GetMouseButtonDown(0))
            {
                float dist = Vector3.Distance(transform.position, go_ItemHolder.transform.position);
                lastObject.SendMessage("Enable");
                lastObject.transform.parent = null;
                lastObject.GetComponent<Rigidbody>().AddForce(camera.transform.forward * (30f-dist*1.5f), ForceMode.Impulse);
                b_HoldingItem = false;
                Debug.Log("Shoot" + dist);
            }
        }
    }
}
