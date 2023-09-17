using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIPopUp : MonoBehaviour
{
    public TMP_Text answerResult;
    public TMP_Text buttonText;
    public Button[] buttonPopUp;
    public LevelManager levelManager;
    
    
    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        
    }

    private void ButtonPopUp()
    {
        for (int i = 0; i < buttonPopUp.Length; i++)
        {
            foreach (var buttons in buttonPopUp)
            {
                
            }
        }
    }
}
