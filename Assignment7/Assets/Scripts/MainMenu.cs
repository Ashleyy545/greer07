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
        Unsliced.gameScore = 0;
        Unsliced.amount = 0;
        SceneManager.LoadScene(0);
        time.timePerQuestion = toggleButtons.timer;

    }

    public void begin()
    {
        SceneManager.LoadScene(0);
        Unsliced.gameScore = 0;
        Unsliced.amount = 0;

    }

    public void startNewGame()
    {
        SceneManager.LoadScene(1);

    }

    public void nextScreen()
    {
        SceneManager.LoadScene(4);
    }

    public void endGame()
    {
        SceneManager.LoadScene(2);

    }
}

