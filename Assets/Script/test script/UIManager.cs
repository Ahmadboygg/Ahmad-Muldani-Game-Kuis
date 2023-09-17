using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;

public class UIManager : MonoBehaviour
{
    public Slider timeSlider = null;
    public GameObject wrongAnswerUI = null;
    public GameObject correctAnswerUI = null;
    private QuizTimer _quizTimer;

    public delegate void onUIMessageConsole(int index);

    private onUIMessageConsole uiMessageConsole;
    private void Start()
    {
        _quizTimer = GetComponent<QuizTimer>();
        timeSlider.maxValue = _quizTimer.setTimer;
    }

    private void Update()
    {
        timeSlider.value = _quizTimer.currenttime;
    }

    private void UIMessageConsole(int index)
    {
        
    }

    
    

    
}
