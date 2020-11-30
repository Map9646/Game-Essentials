using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public FloatData enemyHealth;
    public int health; 
    
    
    void Start()
    {
        enemyHealth.value = 10f; 
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth.value >= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
