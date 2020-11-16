using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class TriggerBehaviour : MonoBehaviour
{
    public GameObject prefab; 
    private void OnTriggerEnter(Collider other)
    {
         Instantiate(prefab); 
         
        
    }
    
    
}





    
    
