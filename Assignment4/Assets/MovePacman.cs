using UnityEngine;
using System.Collections;

public class MovePacman : MonoBehaviour
{
    public float speed = 0.4f;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        // Move closer to Destination
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * speed);
    }


}
