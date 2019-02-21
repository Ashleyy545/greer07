using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{

    public Text text;

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f, -1 * Time.deltaTime, 0f);
        if (transform.position.y < -4)
        {
            Destroy(gameObject);
            TryAgain();
        }
        
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(3);
    }

}