using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIPopUp : MonoBehaviour
{
    public GameObject messageConsoleObject;
    public TMP_Text answerResult;
    public Button[] buttonPopUp;
    public LevelManager levelManager;
    private int buttonIndex;
    
    public void ShowMessageConsole(bool isCorrect)
    {
        if (isCorrect)
        {
            answerResult.text = "Jawabanmu Benar !";
            messageConsoleObject.gameObject.SetActive(true);
            buttonPopUp[0].gameObject.SetActive(true);
            buttonPopUp[0].onClick.AddListener(()=>
            {
                levelManager.nextLevel();
                buttonPopUp[0].gameObject.SetActive(false);
                messageConsoleObject.gameObject.SetActive(false);
            });            
        }
        else
        {
            answerResult.text = "Jawabanmu Salah !";
            messageConsoleObject.gameObject.SetActive(true);
            buttonPopUp[1].gameObject.SetActive(true);
            buttonPopUp[1].onClick.AddListener(()=>
            {
                levelManager.resetLevel();
                buttonPopUp[1].gameObject.SetActive(false);
                messageConsoleObject.gameObject.SetActive(false);
            });
        }
    }
}
