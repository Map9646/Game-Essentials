using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class FriendsTriggerBehaviour : MonoBehaviour
{
    private GameObject friends;
  
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Friend"))
        {
            gameObject.SetActive(false);
        }

       

        
       
    }
    
}
