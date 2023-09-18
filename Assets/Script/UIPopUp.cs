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
    public event Action<bool> timePaused;
    public event Action resetTime;

    private void Start()
    {
        timePaused.Invoke(false);
    }

    public void ShowMessageConsole(bool isCorrect)
    {
        if (isCorrect)
        {
            timePaused.Invoke(true);
            answerResult.text = "Jawabanmu Benar !";
            messageConsoleObject.gameObject.SetActive(true);
            buttonPopUp[0].gameObject.SetActive(true);
            buttonPopUp[0].onClick.AddListener(()=>
            {
                levelManager.nextLevel();
                buttonPopUp[0].gameObject.SetActive(false);
                messageConsoleObject.gameObject.SetActive(false);
                resetTime.Invoke();
                timePaused.Invoke(false);
            });            
        }
        else
        {
            timePaused.Invoke(true);
            answerResult.text = "Jawabanmu Salah !";
            messageConsoleObject.gameObject.SetActive(true);
            buttonPopUp[1].gameObject.SetActive(true);
            buttonPopUp[1].onClick.AddListener(()=>
            {
                levelManager.resetLevel();
                buttonPopUp[1].gameObject.SetActive(false);
                messageConsoleObject.gameObject.SetActive(false);
                timePaused.Invoke(false);
            });
        }
    }
}
