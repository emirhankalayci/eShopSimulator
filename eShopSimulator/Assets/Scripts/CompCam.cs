using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompCam : MonoBehaviour
{   
    public GameObject pcCam;
    public KeyCode switchKey;
  
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pcArea")
        {
            Debug.Log("girdi");
            pcCam.SetActive(true);
            /*
            if (Input.GetKeyDown(switchKey))
            {
                
                
            }
            */
        }
    }
}
