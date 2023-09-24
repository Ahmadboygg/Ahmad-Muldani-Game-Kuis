using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
public class LevelManager : MonoBehaviour
{

    [SerializeField] private QuizLevelPack _quizLevelPack = null;
    [SerializeField] private int quizIndex;
    [SerializeField] private UI_Question _uiQuestion;
    [SerializeField] private UI_AnswerChoice[] _uiAnswerChoice = new UI_AnswerChoice[0];
    private int correctIndex;
    public bool isCorrectAnswer;

    private void Start()
    {
       NextQuestion();
    }

    public void NextQuestion()
    {
        quizIndex++;
        if (quizIndex >= _quizLevelPack.muchLevel)
        {
            quizIndex = 0;
        }

        Quiz quizData = _quizLevelPack.GetQuizLevel(quizIndex);
        _uiQuestion.SetQuestionUI(quizData.questionText, quizData.questionHintImage);
        
        for (int i = 0; i < _uiAnswerChoice.Length; i++)
        {
            UI_AnswerChoice answerChoice = _uiAnswerChoice[i];
            Quiz.QuizData data = quizData.quizAnswerChoices[i];
            answerChoice.SetAnswerChoicesUI(data.answerChoicesText, data.isCorrectAnswers);
        }
    }

    public void CorrectAnswerCheck()
    {
        
    }
}
