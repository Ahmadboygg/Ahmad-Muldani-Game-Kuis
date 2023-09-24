using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_GameOver : MonoBehaviour
{
   private void Start()
   {
      gameObject.SetActive(false);
   }

   public void RetryGame()
   {
      SceneManager.LoadScene(0);
   }
}
