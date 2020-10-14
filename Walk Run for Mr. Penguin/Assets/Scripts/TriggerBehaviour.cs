using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class TriggerBehaviour : MonoBehaviour
{
    
    
    public MeshRenderer gcolor;
    public Color defaultColor;
    public Color newColor; 
    
    void Start()
    {
        gcolor = GetComponent <MeshRenderer>();
        gcolor.material.color = defaultColor; 
    }

    private void OnTriggerEnter(Collider other)
    {
        gcolor.material.color = newColor; 
    }

    private void OnTriggerExit(Collider other)
    {
        gcolor.material.color = defaultColor; 
    }
}





    
    
