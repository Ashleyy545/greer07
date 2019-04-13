using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    public static int round = 0;

	void OnTriggerEnter2D ()
	{
        SceneManager.LoadScene(2);
        
   	}

    public void endGame()
    {
        Score.CurrentScore += Frog.gameScore;
        SceneManager.LoadScene(3);
        round = round + 1;
    }
    public void nextLevel()
    {
        Score.CurrentScore += Frog.gameScore;
        Frog.gameScore = 100;
        SceneManager.LoadScene(1);
        round = round + 1;
    }
}
