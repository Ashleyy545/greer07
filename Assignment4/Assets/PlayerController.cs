using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerController : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;

    public ThirdPersonCharacter character;

    public float speed = 2f;

    public float score;

    private CharacterController controller;

    public TextMesh countText;

    public AudioClip sound;

    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * speed);
    }




    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
            other.gameObject.SetActive(false);
            score += 1;
            SetScore();
        }

        if (score == 169)
        {
            SceneManager.LoadScene("Win");
        }
    }

    void SetScore()
    {
        countText.text = "Count: " + score.ToString();

    }
}
