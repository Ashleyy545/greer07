using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawn : MonoBehaviour
{
    public GameObject fruitPrefab;
    public Transform[] spawnPoints;

    public float minDelay = .1f;
    public float maxDelay = 1f;

    public static bool spawn = true;

    // Use this for initialization
    void Start()
    {
        if (spawn == true)
        {
            StartCoroutine(SpawnFruits());
        }
    }

    IEnumerator SpawnFruits()
    {
        while (true)
        {
            //float delay = Random.Range(minDelay, maxDelay);
            float delay = DropDownSelect.spawnSpeed;
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            
            Transform spawnPoint = spawnPoints[spawnIndex];

            GameObject spawnedFruit = Instantiate(fruitPrefab, spawnPoint.position, spawnPoint.rotation);
            Destroy(spawnedFruit, 5f);
        }
    }

    

}
