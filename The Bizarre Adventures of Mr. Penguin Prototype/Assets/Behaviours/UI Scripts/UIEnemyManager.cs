using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class UIEnemyManager : MonoBehaviour
{
    
    [SerializeField] private Image enemyHealth; 

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            enemyHealth.enabled = true;
            
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            enemyHealth.enabled = false;
             
        }
    }
}
