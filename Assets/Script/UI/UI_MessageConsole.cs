using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_MessageConsole : MonoBehaviour
{
    [SerializeField] private LevelManager _levelManager;
    [SerializeField] private UI_Timer _uiTimer;
    
    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void NextQuestion()
    {
        _levelManager.NextQuestion();
        _uiTimer.ResetBackQuizTime();
        gameObject.SetActive(false);
    }
    
    public void RetryQuestion()
    {
        gameObject.SetActive(false);
    }
}
