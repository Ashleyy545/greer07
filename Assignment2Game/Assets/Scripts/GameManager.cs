using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Question[] questions;
    public Answer[] answers;
    private static List<Question> unansweredQuestions;
    private Question currentQuestion;
    [SerializeField]
    private Text question;
    [SerializeField]
    private Text answerA;
    [SerializeField]
    private Text answerB;
    [SerializeField]
    private Text answerC;
    [SerializeField]
    private Text answerD;
    [SerializeField]
    private float timeBetweenQuestions = 1.5f;
    [SerializeField]
    private Text QuestionsLeft;
    [SerializeField]
    private Text Correct;
    [SerializeField]
    private Text Time;
    private static int numCorrect;
    private Text Score;
    private float timePerQuestion = 10f;
    public TextAsset inputFile;


    private void Start()
    {
        if (unansweredQuestions == null)
        {
            unansweredQuestions = questions.ToList<Question>();
        }
        else if (unansweredQuestions.Count == 0)
        {
            SceneManager.LoadScene(1);   
        }
        loadGame();
    }

    public void loadGame()
    {
        string[] input = inputFile.text.Split(new char[] { '\n' });
        List<int> row = Enumerable.Range(1, 9).OrderBy(g => System.Guid.NewGuid()).Take(1).ToList();
        List<int> col = Enumerable.Range(0, 4).OrderBy(g => System.Guid.NewGuid()).Take(4).ToList();

        int[] intArray = col.ToArray();
        System.Random rando = new System.Random();
        List<int> cell = col.Take(1).ToList();
        col.Skip(1);
        col = Enumerable.Range(0, 4).OrderBy(g => System.Guid.NewGuid()).Take(4).ToList();
        SetCurrentQuestion(input, row, cell);
        SetAnswers(input, row, col, cell);
    }



    void SetCurrentQuestion(string[] input, List<int> row, List<int> cell)
    {
        string spanishTense = input[0];
        string[] spanish = spanishTense.Split(new char[] { ',' });
        string[] english = input[row[0]].Split(new char[] { ',' });

        int rand = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[rand];
        question.text = english[cell[0] + 6] + "\n" + spanish[cell[0]];
        QuestionsLeft.text = (unansweredQuestions.Count - 1).ToString();
        Correct.text = numCorrect.ToString();

    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);
        yield return new WaitForSeconds(timeBetweenQuestions);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    void SetAnswers(string[] input, List<int> row, List<int> col, List<int> cell)
    {
        string[] spanishAnswers = input[row[0]].Split(new char[] { ',' });

        answerA.text = spanishAnswers[cell[0]];

        if (spanishAnswers[cell[0]] == spanishAnswers[col[0]])
        {
            answerB.text = spanishAnswers[col[3]];
        }
        else
        {
            answerB.text = spanishAnswers[col[0]];
        }

        if (spanishAnswers[cell[0]] == spanishAnswers[col[1]])
        {
            answerC.text = spanishAnswers[col[3]];
        }
        else
        {
            answerC.text = spanishAnswers[col[1]];
        }

        if (spanishAnswers[cell[0]] == spanishAnswers[col[2]])
        {
            answerD.text = spanishAnswers[col[3]];
        }
        else
        {
            answerD.text = spanishAnswers[col[2]];
        }
    }

    public void ButtonA()
    {
        numCorrect++;
        StartCoroutine(TransitionToNextQuestion());
    }

    public void ButtonB()
    {
        StartCoroutine(TransitionToNextQuestion());
    }

    public void ButtonC()
    {
        StartCoroutine(TransitionToNextQuestion());
    }

    public void ButtonD()
    {
        StartCoroutine(TransitionToNextQuestion());
    }

    public void SetScore()
    {
        Score.text = " " + numCorrect;
    }

    private void Update()
    {
        timePerQuestion -= UnityEngine.Time.deltaTime;
        Time.text = (timePerQuestion).ToString("0");

        if (timePerQuestion <= 0f)
        {
            SceneManager.LoadScene(1);
        }
    }

}

