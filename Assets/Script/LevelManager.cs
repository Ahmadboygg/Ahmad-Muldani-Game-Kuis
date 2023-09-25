using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
public class LevelManager : MonoBehaviour
{
    [SerializeField] private PlayerProgress _playerProgress;
    [SerializeField] private QuizLevelPack _quizLevelPack = null;
    [SerializeField] private int quizIndex;
    [SerializeField] private UI_Question _uiQuestion;
    [SerializeField] private UI_AnswerChoice[] _uiAnswerChoice = new UI_AnswerChoice[0];
    public bool isCorrectAnswer;
    [SerializeField] private UI_QuizLevel _uiQuizLevel;
    private int correctIndex;

    private void Start()
    {
        if (!_playerProgress.LoadData())
        {
            _playerProgress.SaveData();
        }
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
        _uiQuizLevel.SetQuizLevelText($"Soal Ke - {quizIndex + 1}");
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
