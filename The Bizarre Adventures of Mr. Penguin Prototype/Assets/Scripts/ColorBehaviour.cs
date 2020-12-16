using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBehaviour : MonoBehaviour
{
    public Material newMaterial;
    public Material defaultMaterial;

    private MeshRenderer meshR; 
    // Start is called before the first frame update
    void Start()
    {
        meshR = GetComponent<MeshRenderer>();
        meshR.material = defaultMaterial;
    }

    private void OnTriggerEnter(Collider other)
    {
        meshR.material = newMaterial;
    }

    private void OnTriggerExit(Collider other)
    {
        meshR.material = newMaterial; 
    }
}
