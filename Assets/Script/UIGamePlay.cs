using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIGamePlay : MonoBehaviour
{
    public Image imageQuestionHint = null;
    public TMP_Text questionText = null;
    public TMP_Text[] answerText;
    public UIPopUp uiPopUp;
    public Slider timeSlider = null;
    public Button[] choiceButton;
    private LevelManager levelManager;
    private QuizTimer quizTimer;
    private int choiceDataIndex;

    private void Start()
    {
        levelManager = GetComponentInChildren<LevelManager>();
        uiPopUp = GetComponentInChildren<UIPopUp>();
        quizTimer = GetComponent<QuizTimer>();
        timeSlider.maxValue = quizTimer.setTimer;
        SetCorrectAnswer(levelManager._quizData[levelManager.index].isCorrectAnswer);
    }

    private void Update()
    {
        SetUIData(levelManager._quizData[levelManager.index].question,levelManager._quizData[levelManager.index].answerChoice,
            levelManager._quizData[levelManager.index].questionImage);
        timeSlider.value = quizTimer.currenttime;
    }

    private void SetUIData(string _questionText, string[] _answerText, Sprite imageHint)
    {
        questionText.text = _questionText;
        imageQuestionHint.sprite = imageHint;
        for (int i = 0; i < answerText.Length; i++)
        {
            answerText[i].text = _answerText[i];
        }
    }

    private void SetCorrectAnswer(bool[] trueChoice)
    {
        for (int i = 0; i < choiceButton.Length; i++)
        {
            int buttonIndex = i;
            choiceButton[buttonIndex].onClick.AddListener(() => uiPopUp.ShowMessageConsole(trueChoice[buttonIndex]));
        }
    }

   
}
