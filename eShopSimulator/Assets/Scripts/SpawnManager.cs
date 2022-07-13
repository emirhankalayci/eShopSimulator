using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject box;
   
    public void spawnBox()
    {
        Vector3 spawnPos = new Vector3(44.004f, 4.36f, 7.06f);
        Instantiate(box,spawnPos,box.transform.rotation);
    }
   

}
