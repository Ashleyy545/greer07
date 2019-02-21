using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WordGenerator : MonoBehaviour
{
    public TextAsset inputFile;
    public static string[] my_input;


    public void Awake()
    {
        my_input = inputFile.text.Split(new char[] { '\n' });
        Debug.Log(my_input);

        int j = 0;
        foreach (string s in my_input)
        {
            my_input[j] = s.Trim();

            j += 1;
        }
    }

    public static string GetRandomWord()
    {


        int randomIndex = Random.Range(0, my_input.Length);
        string randomWord = my_input[randomIndex];

        return randomWord;
    }
    
}