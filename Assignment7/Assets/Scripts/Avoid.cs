using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Avoid : MonoBehaviour
{

    
    public static float startForce = 15f;

    Rigidbody2D rb;


    private void Update()
    {

    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            SceneManager.LoadScene(3);
        }

    }


}
