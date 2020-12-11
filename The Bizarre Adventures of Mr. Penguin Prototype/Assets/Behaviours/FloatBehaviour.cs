﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class FloatBehaviour : MonoBehaviour
{
    public float health; 
    public string otherTag = "Player";
    public UnityEvent triggerEnterEvent, atZeroEvent;

    private void Start()
    {
        //value = data.value;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(otherTag)) return;
        var otherValue = other.GetComponent<FloatContainer>();
        if (otherValue == null) return;
        UpdateValue(otherValue.value);
        triggerEnterEvent.Invoke();
    }

    public void UpdateValue(float number)
    {
        health += number;
        
        if (health <= 0)
        {
            atZeroEvent.Invoke();
        }
    }
}
