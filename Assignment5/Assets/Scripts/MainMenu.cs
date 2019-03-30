using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
    public void goToMain()
    {
        SceneManager.LoadScene(0);
    }

    public void restartRound()
    {

        SceneManager.LoadScene(1);
    }

    public void startNewGame()
    {

        Score.CurrentScore = 0;
        SceneManager.LoadScene(1);
    }

 
}

