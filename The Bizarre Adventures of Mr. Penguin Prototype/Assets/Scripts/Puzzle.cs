using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    private MeshRenderer meshR;
    public Color defaultColor;
    public Color newColor;
    //private WaitForSeconds wfs;
    public int holdTime =30;
    public IntData myCounter; 
    void Start()
    {
        meshR = GetComponent <MeshRenderer>();
        meshR.material.color = defaultColor; 
        //wfs = new WaitForSeconds(holdTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        meshR.material.color = newColor;
        myCounter.value++;
        

    }

    private void OnTriggerExit (Collider other)
    {
        //yield return wfs; 
        meshR.material.color = newColor;
        
        
    }

    
    
}
