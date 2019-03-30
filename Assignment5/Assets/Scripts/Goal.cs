using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	void OnTriggerEnter2D ()
	{
        if (Score.CurrentScore != 900)
        {
            SceneManager.LoadScene(2);
        }
        
        else
        {
            SceneManager.LoadScene(3);
            Debug.Log("YOU WON!");
            Score.CurrentScore = 0;
        }
   	}

    public void repeatLevel()
    {
        SceneManager.LoadScene(1);
        
    }
    public void nextLevel()
    {
        Score.CurrentScore += 100;
        SceneManager.LoadScene(1);

    }
}
