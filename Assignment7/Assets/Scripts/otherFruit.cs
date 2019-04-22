using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherFruit : MonoBehaviour
{

    public static float startForce = 15f;

    static Rigidbody2D rb;


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
            Unsliced.gameScore += 1;
            Destroy(gameObject);
        }

    }

    public void OnBecameInvisible()
    {

        Unsliced.amount += 1;

    }


}
