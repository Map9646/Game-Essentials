using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI; 

public class FriendsUIManager : MonoBehaviour
{
    [SerializeField] private Image friendImage;
     

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            friendImage.enabled = true;
            
        }
        
        
    }
}
