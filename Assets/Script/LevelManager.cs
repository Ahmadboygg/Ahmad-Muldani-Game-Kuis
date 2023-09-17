using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [System.Serializable]
    public struct QuizData
    {
        public string question;
        public Sprite questionImage;

        public string[] answerChoice;
        public bool[] isCorrectAnswer;
    }

    public QuizData[] _quizData = new QuizData[0];
    public int index;

    private void nextLevel()
    {
        index++;
        if (index >= _quizData.Length)
        {
            index = 0;
        }
        QuizData quizData = _quizData[index];
    }

    private void resetLevel()
    {
        index = 0;
        QuizData quizData = _quizData[index];
    }

    public void CorrectAnswer(int index)
    {
        nextLevel();
    }

    public void WrongAnswer(int index)
    {
        resetLevel();
    }
}
