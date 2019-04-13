using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lives : MonoBehaviour
{
    public GameObject heart1, heart2, heart3;
    public static int health;
    [SerializeField]
    private Text Time;
    private float timePerQuestion = 15f;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {

        timePerQuestion -= UnityEngine.Time.deltaTime;
        Time.text = (timePerQuestion).ToString("0");
        
        if (timePerQuestion <= 0f)
        {
            SceneManager.LoadScene(3);
        }

        if (health > 3)
            health = 3;

        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
        }
    }
}
