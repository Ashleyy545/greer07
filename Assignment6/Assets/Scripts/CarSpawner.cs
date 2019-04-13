using UnityEngine;

public class CarSpawner : MonoBehaviour {

	public float spawnDelay = .3f;

	public GameObject car;

	public Transform[] spawnPoints;

	float nextTimeToSpawn = 0f;

	void Update ()
	{
		if (nextTimeToSpawn <= Time.time)
		{
			SpawnCar();
            spawnDelay = DropDownSelect.spawnSpeed;
            nextTimeToSpawn = Time.time + spawnDelay;
		}

        car.transform.localScale = DropDownSelect.size;
    }

	void SpawnCar ()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[randomIndex];

		Instantiate(car, spawnPoint.position, spawnPoint.rotation);
	}

}
