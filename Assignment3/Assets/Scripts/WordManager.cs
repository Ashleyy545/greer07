using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WordManager : MonoBehaviour
{

    public List<Word> words;
    public Text countText;
    public WordSpawner wordSpawner;

    private bool hasActiveWord;
    private Word activeWord;
    private int count;

    private void Start()
    {
        count = 0;
        SetCountText();
    }

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
            count += 1;
            SetCountText();

            if ( count == 10)
            {
                SceneManager.LoadScene(2);
            }
        }
    }

    public void goToGame()
    {
        SceneManager.LoadScene(1);
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }


    public void goToMenu()
    {
        SceneManager.LoadScene(0);
    }
}