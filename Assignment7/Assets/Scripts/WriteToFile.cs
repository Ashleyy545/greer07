using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;
using System;
using System.Linq;

public class WriteToFile : MonoBehaviour
{
    // attached to camera so it is the first thing done in this scene
    public Text Summary ;
    public Text HighScores;

    // Start is called before the first frame update
    void Start()
    {
        Summary.text = "Player: " + ReadFromFile.user +  "\nTotal Score: " + Unsliced.gameScore + "\nMissed: " + Unsliced.unTouched; 
        //Summary.text = "Player: ";
        WriteString();
        highestScore();

    }


    public void WriteString()
    {
        string path = "Assets/Resources/test.txt";

        StreamWriter writer = new StreamWriter(path, true);
        
        writer.Write(ReadFromFile.user); 
        writer.Write(',');
        writer.Write(Unsliced.gameScore);
        writer.Write("\r\n");
        writer.Close();
        
        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("test");

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



