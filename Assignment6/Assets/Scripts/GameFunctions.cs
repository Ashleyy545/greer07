using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameFunctions : MonoBehaviour
{
    public Text mytext;
    public void Pause()
    {
        mytext.text = "Resume Game";
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            mytext.text = "Pause Game";
            Time.timeScale = 1;
        }
    }

    public void goToMenu()
    {
        SceneManager.LoadScene(5);
        
    }
}
