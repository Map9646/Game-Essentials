using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    public IntData myCounter;
    


    private void Start()
    {
        myCounter.value = 0; 
    }
    private void Update()
    {
        if (myCounter.value >= 6)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
            
            
        }

        
        //if (myCounter.value < 4)
        //{
            
        //}
    }
}
