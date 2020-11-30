using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TextUIManager : MonoBehaviour
{
    [SerializeField] private Text missionText;
    [SerializeField] private Image outlineText; 

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            missionText.enabled = true;
            outlineText.enabled = true; 
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            missionText.enabled = false;
            outlineText.enabled = false; 
        }
    }
}
