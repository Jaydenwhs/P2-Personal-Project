using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPress : MonoBehaviour 
{
   public Button startButton;

   private void Awake()
   {
       Time.timeScale = 0f;
   }

   private void OnEnable()
   {
      startButton.onClick.AddListener(StartGame);
   }

   private void OnDisable()
   {
      startButton.onClick.RemoveListener(StartGame);
   }

   private void StartGame()
   {
      Time.timeScale = 1f;

      // Hides the button
      startButton.gameObject.SetActive(false);
   }
}

