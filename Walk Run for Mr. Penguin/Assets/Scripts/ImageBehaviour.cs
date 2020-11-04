using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
[RequireComponent(typeof(Slider))]
public class ImageBehaviour : MonoBehaviour
{
    private Slider healthSlider;
    public FloatData health;
    public FloatData maxHealth;
     

    private void Start()
    {
        healthSlider = GetComponent<Slider>();
    }

    private void Update()
    {
        healthSlider.value = health.value; 


    }
    
    
}
