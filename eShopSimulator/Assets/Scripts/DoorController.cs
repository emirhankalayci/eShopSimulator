using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject instructions;
    private CompCam compCam;


    private void Awake()
    {
        compCam = GetComponent<CompCam>();       
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "doorArea" && compCam.openable == true)
        {
            instructions.SetActive(true);        
            Animator anim = other.GetComponentInChildren<Animator>();             
            if (Input.GetKeyDown(KeyCode.E))
                anim.SetTrigger("OpenClose"); 
        }
    }
    
    private void OnTriggerExit(Collider other)
    {        
        if (other.tag == "doorArea")
        {           
            instructions.SetActive(false);
        }
    }
}