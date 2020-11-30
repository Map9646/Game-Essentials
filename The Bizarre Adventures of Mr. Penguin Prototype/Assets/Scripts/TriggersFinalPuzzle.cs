using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersFinalPuzzle : MonoBehaviour
{
    public GameObject trigger;
    public GameObject cageTrigger;
    

    


    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("FinalTrigger"))
        {
            trigger.gameObject.SetActive(true);
        }

        if (gameObject.CompareTag("SavePoppyTrigger"))
        {
            cageTrigger.gameObject.SetActive(false);
        }
    }
}
