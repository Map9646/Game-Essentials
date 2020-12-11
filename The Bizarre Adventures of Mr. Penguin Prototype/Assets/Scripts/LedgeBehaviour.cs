using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeBehaviour : MonoBehaviour
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
            
            gameObject.SetActive(true);
            
            
        }

    }
    
}
