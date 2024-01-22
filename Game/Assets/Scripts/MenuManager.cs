using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
   public GameObject settingsPanel;

   public void PlayGame()
   {
    Application.LoadLevel("Game");
   }

   public void ExitGame()
   {
    Application.Quit();
   }

   // public void settingsPanel()
   // {
   //  settingsPanel.SetActive(true);
   // }

   // public void Exit()
   // {
   //  settingsPanel.SetActive(false);
   // }
}  
