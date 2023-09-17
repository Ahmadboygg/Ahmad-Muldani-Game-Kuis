using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QuizAnswerButton : MonoBehaviour
{
    private Button[] buttons;

    private void Start()
    {
        buttons = GetComponentsInChildren<Button>();
        for (int i = 0; i < buttons.Length; i++)
        {
            int buttonIndex = i;
            Quiz quiz = buttons[i].GetComponentInParent<Quiz>();
            buttons[i].onClick.AddListener(() => quiz.CorrectAnswer(buttonIndex) );
        }
    }
}
