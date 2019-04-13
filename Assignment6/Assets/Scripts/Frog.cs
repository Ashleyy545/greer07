using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Frog : MonoBehaviour {
    public Rigidbody2D rb;
    public AudioClip squash;
    public AudioClip hop;

    public Text CurrentScoreText;
    public static int gameScore = 100;


    void Update () {

        transform.localScale = DropDownSelect.frogSize;
        CurrentScoreText.text = gameScore.ToString();

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
            AudioSource.PlayClipAtPoint(hop, transform.position);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
            AudioSource.PlayClipAtPoint(hop, transform.position);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
            AudioSource.PlayClipAtPoint(hop, transform.position);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
            AudioSource.PlayClipAtPoint(hop, transform.position);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            if (lives.health != 0)
            {
                AudioSource.PlayClipAtPoint(squash, transform.position);
                lives.health -= 1;
                gameScore -= 20;
                rb.transform.position = new Vector3(0, -4, 0);
            }
            else
            {
               SceneManager.LoadScene(3);
            }
        }

    }
}
