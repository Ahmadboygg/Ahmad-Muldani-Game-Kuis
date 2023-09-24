using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizTimer : MonoBehaviour
{
    public float setTimer;
    [HideInInspector]
    public float currenttime;
    private float pausedTime;
    private UIPopUp _uiPopUp;

    private void Start()
    {
        _uiPopUp = GetComponentInChildren<UIPopUp>();
        _uiPopUp.timePaused += TimePaused;
        _uiPopUp.resetTime += ResetTime;
        currenttime = setTimer;
    }

    private void Update()
    {
        Time.timeScale = pausedTime;
        currenttime -= Time.deltaTime;
        if (currenttime <= 0)
        {
            currenttime = 0;
        }
    }

    public void TimePaused(bool ispaused)
    {
        pausedTime = ispaused ? pausedTime = 0 : 1;
    }

    public void ResetTime()
    {
        currenttime = setTimer;
    }
}
