using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Question : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI questionTMP = null;
    [SerializeField] private Image questionImage = null;

    public void SetQuestionUI(string questionText, Sprite questionHintImage)
    {
        questionTMP.text = questionText;
        questionImage.sprite = questionHintImage;
    }
}
