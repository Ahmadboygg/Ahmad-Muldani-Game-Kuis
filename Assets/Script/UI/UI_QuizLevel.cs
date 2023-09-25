using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_QuizLevel : MonoBehaviour
{
    [SerializeField] private TMP_Text quizLevelText;

    public void SetQuizLevelText(string levelText)
    {
        quizLevelText.text = levelText;
    }
}
