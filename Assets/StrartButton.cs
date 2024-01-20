using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StrartButton : MonoBehaviour
{
    public string nextLevel = "Level1";

   public void NewGameButton()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
