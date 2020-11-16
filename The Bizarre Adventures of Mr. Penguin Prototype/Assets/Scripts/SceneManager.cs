using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    public Vector3Data currentSpawnPoint; 
    
    private void OnTriggerEnter(Collider other)
    {
        
        {
            if (gameObject.CompareTag("Trigger Wall to Village"))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("The Village");
               
            }

            if (gameObject.CompareTag("Puzzle Cave"))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("The Puzzle and Boss Room");
            }

            if (gameObject.CompareTag("Trigger"))
            {
                transform.position = currentSpawnPoint.value; 
                UnityEngine.SceneManagement.SceneManager.LoadScene("Enviornment of Game");
                

            }
            
        }
    }
}
