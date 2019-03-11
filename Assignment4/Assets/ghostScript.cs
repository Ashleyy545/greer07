using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class ghostScript : MonoBehaviour
{

    public GameObject target;   //this is the player or a reference for him
    NavMeshAgent agent;         //this is a reference for the ghost navmeshagent component

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (target == null)
            target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //this is for updating the target location
        agent.destination = target.transform.position;
    }


    //function to detect when the ghost gets the player
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Player"))
            SceneManager.LoadScene("GameOver");
    }



}
