using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Timer : MonoBehaviour
{
    [SerializeField] private Slider timeSlider;
    [SerializeField] private float quizTime;
    private float currentQuizTime;
    void Start()
    {
        currentQuizTime = quizTime;
        timeSlider.maxValue = quizTime;
    }

    void Update()
    {
        currentQuizTime -= Time.deltaTime;
        timeSlider.value = currentQuizTime;
        
        if (currentQuizTime <= 0)
        {
            currentQuizTime = 0;
        }
    }

    public void ResetBackQuizTime()
    {
        currentQuizTime = quizTime;
    }

    public void PausedTime(bool paused)
    {
        if (paused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
