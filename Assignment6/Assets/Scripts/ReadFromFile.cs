using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;
using System;
using System.Linq;

public class ReadFromFile : MonoBehaviour
{
    //public Text fileContents;

    public InputField playerName;
    public Text UserName;
    public Text playerScores;
    public Text HighScores;

    public static string user;

    public void displayName()
    {
        UserName.text = playerName.text;
        user = UserName.text;
        highScores();
        highestScore();
    }

    public void highScores()
    {
        string path = "Assets/Resources/test.txt";
        string[] lines = File.ReadAllLines(path);
        string[] fields;
        foreach (string line in lines)
        {
            if (line.Contains(ReadFromFile.user))
            {
                fields = line.Split(',');
                playerScores.text += "Player: " + fields[0] + "\t\t  Score: " + fields[1] + "\r\n";
            }
        }
    }


    void highestScore()
    {
        string[] lines = File.ReadAllLines("Assets/Resources/test.txt");
        string[][] data = new string[100][];
        string[] bigest = new string[] { "", "" };

        int i = 0;
        foreach (string line in lines)
        {
            if (!line.Contains(','))
            {
                break;
            }

            string[] fields = line.Split(',');

            data[i] = new string[] { fields[0], fields[1] };

            i++;

        }

        bigest = GetLargest(data, "-1", i);
        HighScores.text += bigest[0] + "\t\t" + bigest[1] + "\r\n";

        bigest = GetLargest(data, bigest[1], i);
        HighScores.text += bigest[0] + "\t\t" + bigest[1] + "\r\n";

        bigest = GetLargest(data, bigest[1], i);
        HighScores.text += bigest[0] + "\t\t" + bigest[1] + "\r\n";
    }

    static String[] GetLargest(string[][] dt, string target, int array_size)
    {
        int num;
        int target_num;
        int prev_num = 0;
        string[] result = new string[] { "", "" };

        if (Int32.TryParse(target, out target_num))
        {
            if (target_num < 0)
            {
                target_num = 0x7fffffff; // make this largest possible positive int value
            }

            for (int i = 0; i < array_size; i++)
            {

                if (Int32.TryParse(dt[i][1], out num))
                {
                    if (num > prev_num)
                    {
                        if (num >= target_num)
                        {
                            continue;
                        }

                        result[0] = dt[i][0];
                        result[1] = dt[i][1];
                        prev_num = num;
                    }
                }

            }
        }
        return (result);
    }

}