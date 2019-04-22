using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    
    public Text Time;
    public static float timePerQuestion = 90f;



    // Update is called once per frame
    void Update()
    {

        timePerQuestion -= UnityEngine.Time.deltaTime;
        Time.text = (timePerQuestion).ToString("0");

        if (timePerQuestion <= 0f)
        {
            SceneManager.LoadScene(3);
        }


    }

}


