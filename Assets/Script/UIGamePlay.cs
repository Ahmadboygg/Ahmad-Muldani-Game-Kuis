using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class UIGamePlay : MonoBehaviour
{
    public Image imageQuestionHint = null;
    public TMP_Text questionText = null;
    public TMP_Text[] answerText;
    private LevelManager levelManager;
    private void Start()
    {
        levelManager = GetComponentInChildren<LevelManager>();
    }

    private void Update()
    {
        SetUIData(levelManager._quizData[levelManager.index].question,levelManager._quizData[levelManager.index].answerChoice,levelManager._quizData[levelManager.index].questionImage);
    }

    private void SetUIData(string _questionText, string[] _answerText, Sprite imageHint)
    {
        questionText.text = _questionText;
        for (int i = 0; i < answerText.Length; i++)
        {
            answerText[i].text = _answerText[i];
        }
        imageQuestionHint.sprite = imageHint;
    }

    private void SetCorrectAnswer(bool[] trueChoice)
    {
        foreach (var choices in trueChoice)
        {
            Debug.Log(choices);
        }
    }
}
