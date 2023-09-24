using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (menuName = "Create Quiz Data", fileName = "New Quiz Data")]
public class Quiz : ScriptableObject
{
    [System.Serializable]
    public struct QuizData
    {
        public string answerChoicesText;
        public bool isCorrectAnswers;
    }

    public string questionText = string.Empty;
    public Sprite questionHintImage = null;
    public QuizData[] quizAnswerChoices = new QuizData[0];
    
}
