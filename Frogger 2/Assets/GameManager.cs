using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject[] vehicles;
    float vehicleSpeed = 0;
    int points = 0;

    float timer = 0;
    [SerializeField] float timeTillSpawn;
    [SerializeField] float spawnDelay;
    [SerializeField] int chance;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeTillSpawn)
        {
            SpawnTraffic();
        }
    }

    public void SpawnTraffic()
    {
        foreach (Transform spawn in spawnPoints)
        {
            int spawnChance= Random.Range(0, 100);

            if (spawnChance > chance)
            {
                GameObject clone = Instantiate(vehicles[Random.Range(0, vehicles.Length)], spawn.position, Quaternion.Euler(0, 0, 0));

                

            }
        }
    }
}
