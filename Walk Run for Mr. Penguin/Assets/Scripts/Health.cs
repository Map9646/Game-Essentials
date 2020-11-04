using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public FloatData health;
    public FloatData maxHealth; 
    public float healthUpLevel = 10f;
    
   
    
    
    private void OnTriggerEnter(Collider other)
    {
        health.value += healthUpLevel; 
        
       
    }

    private void Update()
    {
        if (health.value >= 100)
        {
            health.value = maxHealth.value; 
        }
    }
}
