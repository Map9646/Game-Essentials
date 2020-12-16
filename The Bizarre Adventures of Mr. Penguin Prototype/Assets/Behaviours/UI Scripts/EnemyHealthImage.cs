using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class EnemyHealthImage : MonoBehaviour
{
    public Image healthBar;

    public float health;
    private float tempValue;
    


    void Start()
    {
        healthBar = GetComponent<Image>();
        




    }

    //public void UpdateFillAmount()
    //{
    //StartCoroutine(OnUpdateFillAmount());
    //}

    // Update is called once per frame
    
    
    void Update()
    {

        healthBar.fillAmount = health / 100; 
        healthBar.color = Color.red;

        //if (health.value >= 40)
        //{
        //healthBar.color = Color.yellow;
            
        //}

        //if (health.value >= 10)
        //{
        //healthBar.color = Color.red; 
        //}
    }

    
}
