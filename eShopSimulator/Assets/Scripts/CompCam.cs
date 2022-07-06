using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompCam : MonoBehaviour
{
    public GameObject instruction1;
    public GameObject instruction2;
    public GameObject pcCam;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "pcArea")
        {
            instruction1.SetActive(true);     
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                //instruction1.SetActive(false);
                transform.position = new Vector3(77.241f, 2.881f, 16.843f);               
            }                             
        }

        if (other.tag == "pcArea2")
        {
            instruction2.SetActive(true);
            pcCam.SetActive(true);

            if (Input.GetKeyDown(KeyCode.X))
            {
                transform.position = new Vector3(75.301f, 2.881f, 16.932f);
                pcCam.SetActive(false);
                instruction2.SetActive(false);
            }
                
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "pcArea")
        {
            instruction1.SetActive(false);
        }
    }
}