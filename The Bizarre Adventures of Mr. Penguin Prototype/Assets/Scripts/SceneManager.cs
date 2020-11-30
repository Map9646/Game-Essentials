using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    
    
    private void OnTriggerEnter(Collider other)
    {
        
        {
           

            if (gameObject.CompareTag("Puzzle Cave"))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("The Puzzle and Boss Room");
            }

            if (gameObject.CompareTag("FinalTrigger"))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("Ending");
            }
        }
    }
}
