using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruit : MonoBehaviour {

	public GameObject fruitSlicedPrefab;
	public static float startForce = 15f;

	Rigidbody2D rb;


    public float constantSpeed = 15.5f;

    private void Update()
    {

    }
    void Start ()
	{
        transform.localScale = DropDownSelect.fruit;
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = DropDownSelect.fruitS;


        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);

        
    }

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Blade")
		{
            Unsliced.gameScore += 1;
            Vector3 direction = (col.transform.position - transform.position).normalized;

			Quaternion rotation = Quaternion.LookRotation(direction);

			GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
			Destroy(slicedFruit, 3f);
			Destroy(gameObject);
		}
        
    }

    public void OnBecameInvisible()
    {

        Unsliced.amount += 1;
       
    }
}
