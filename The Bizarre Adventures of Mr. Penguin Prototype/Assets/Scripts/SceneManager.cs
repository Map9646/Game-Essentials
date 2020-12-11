using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public int levelToLoad;

    private void OnTriggerEnter(Collider other)
    {
        
        if (gameObject.CompareTag("FinalTrigger"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Ending");
        }

    }



    public void LoadLevel()
        {
        
            UnityEngine.SceneManagement.SceneManager.LoadScene(levelToLoad);
        }

}
