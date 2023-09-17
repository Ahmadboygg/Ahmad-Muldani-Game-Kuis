using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizTimer : MonoBehaviour
{
    public float setTimer;
    [HideInInspector]
    public float currenttime;

    private void Start()
    {
        currenttime = setTimer;
    }

    private void Update()
    {
        currenttime -= Time.deltaTime;
        if (currenttime <= 0)
        {
            Debug.Log("Time is Over");
            currenttime = 0;
        }
        
        Debug.Log($"{currenttime}");
    }
}
