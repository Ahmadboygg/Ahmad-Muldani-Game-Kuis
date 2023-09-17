using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quiz : MonoBehaviour
{
    public QuizData quizdata;
    public Image quizImage;
    public TMP_Text quizText;
    public TMP_Text[] answerButton;
    void Start()
    {
        GenerateQuiz(quizdata.quizImage, quizdata.quizQuestion,quizdata.quizAnswer);
    }

    void GenerateQuiz(Sprite image, string questionText, string[]answerTextButton)
    {
        quizImage.sprite = image;
        quizText.text = questionText;
        quizdata.InitQuizData();
        for (int i = 0; i < answerButton.Length; i++)
        {
            answerButton[i].text = answerTextButton[i];
        }
    }

    public void CorrectAnswer(int index) => quizdata.choiceAnswer(index);

}
