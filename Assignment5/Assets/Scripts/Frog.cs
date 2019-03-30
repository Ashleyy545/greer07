using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;
    public AudioClip squash;
    public AudioClip hop;

    void Update () {

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
                rb.transform.position = new Vector3(0, -4, 0);
            }
            else
            {
                Score.CurrentScore = 0;
                SceneManager.LoadScene(4);
            }
        }

    }
}
