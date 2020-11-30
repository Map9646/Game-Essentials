using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public Vector3Data position; 
    private void OnTriggerEnter(Collider other)
    {
        if (Instantiate(prefab))
        {
            prefab.transform.position = position.value; 
        }
         


    }
    
    
}





    
    
