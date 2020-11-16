using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCollectors : MonoBehaviour
{
    public IntData myCounter;


    private void OnTriggerEnter(Collider other)
    {
        myCounter.value++;
        Destroy(gameObject);
    }
}
