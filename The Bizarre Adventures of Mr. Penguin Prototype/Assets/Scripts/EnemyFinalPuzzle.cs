using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFinalPuzzle : MonoBehaviour
{
    public GameObject enemy;


    private void Start()
    {
        enemy.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        enemy.gameObject.SetActive(true);
    }
}
