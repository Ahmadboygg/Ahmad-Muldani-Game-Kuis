using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor.VersionControl;
using UnityEngine.Serialization;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "NewQuizData", menuName = "Create Quiz Data")]
public class QuizData : ScriptableObject
{
    public Sprite quizImage = null;
    public string quizQuestion = null;
    public string[] quizAnswer = null;

    public delegate void onChoiceAnswer(int index);

    public onChoiceAnswer choiceAnswer;

    public int correctIndex;
    public void InitQuizData()
    {
        GenerateAnswer();
        choiceAnswer += ChoiceAnswer;
    }

    private void GenerateAnswer()
    {
        for (int i = 0; i < quizAnswer.Length; i++)
        {
            string temp = quizAnswer[i];
        }
    }

    private void ChoiceAnswer(int choiceIndex)
    {
        if (choiceIndex == correctIndex)
        {
            Debug.Log($"Jawaban anda benar ! yaitu {quizAnswer[correctIndex]}");
        }
        else
        {
            Debug.Log($"Jawaban anda salah ! jawaban yang benar yaitu {quizAnswer[correctIndex]}");
        }
    }
}
