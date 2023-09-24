using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerChoiceButton : MonoBehaviour
{
    [SerializeField] private Button[] answerChoiceButton;
    [SerializeField] private LevelManager _levelManager;

    private void Start()
    {
        foreach (var buttons in answerChoiceButton)
        {
            buttons.onClick.AddListener( ()=> _levelManager.NextQuestion());
        }
    }
}
