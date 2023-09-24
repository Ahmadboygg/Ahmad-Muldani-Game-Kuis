using UnityEngine;
using TMPro;

public class UI_AnswerChoice : MonoBehaviour
{
    [SerializeField] private TMP_Text answerChoiceText;
    [SerializeField] private bool correctAnswerChoice;

    public void SetAnswerChoicesUI(string answerText, bool correctAnswer)
    {
        answerChoiceText.text = answerText;
        correctAnswerChoice = correctAnswer;
    }

    public void isCorrectAnswer()
    {
        Debug.Log($"{answerChoiceText.text} adalah {correctAnswerChoice}");
    }
}
