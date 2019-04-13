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
        Score.CurrentScore = 0;
    }

    public void goToMain()
    {
        SceneManager.LoadScene(0);
        Frog.gameScore = 100;
        Score.CurrentScore = 0;
        Goal.round = 0;
    }

    public void startNewGame()
    {
        Frog.gameScore = 100;
        Score.CurrentScore = 0;
        Goal.round = 0;
        SceneManager.LoadScene(1);
    }

    public void nextScreen()
    {
        SceneManager.LoadScene(4);
    }
}

