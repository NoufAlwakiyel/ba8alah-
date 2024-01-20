using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverr : MonoBehaviour
{
   public string nextLevel = "gameover";

   public void NewGameButton()
    {
        SceneManager.LoadScene(nextLevel);
    }
} 

