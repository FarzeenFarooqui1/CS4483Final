using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject rotatingPlatformPrefab; // New rotating platform prefab
    public float spawnDistance = 10f; // Distance ahead of the player to spawn platforms
    public float destroyDistance = 20f; // Distance behind the player to destroy platforms
    public float spawnInterval = 2f; // Interval between platform spawns
    public float minY = -2f; // Minimum height for platform spawning
    public float maxY = 2f; // Maximum height for platform spawning

    private float nextSpawnTime;
    private Transform playerTransform;
    private List<GameObject> spawnedPlatforms = new List<GameObject>();

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        nextSpawnTime = Time.time + spawnInterval; // Initial spawn
    }

    void Update()
    {
        // Spawn platforms
        if (Time.time >= nextSpawnTime)
        {
            SpawnPlatform();
            nextSpawnTime = Time.time + spawnInterval;
        }

        // Destroy platforms behind the player
        DestroyPlatformsBehindPlayer();
    }

    void SpawnPlatform()
    {
        float randomX = playerTransform.position.x + spawnDistance;
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0);

        // Randomly choose between regular platform and rotating platform
        GameObject platformToSpawn = Random.value < 0.5f ? platformPrefab : rotatingPlatformPrefab;

        GameObject newPlatform = Instantiate(platformToSpawn, spawnPosition, Quaternion.identity);
        spawnedPlatforms.Add(newPlatform);
    }

    void DestroyPlatformsBehindPlayer()
    {
        for (int i = 0; i < spawnedPlatforms.Count; i++)
        {
            if (spawnedPlatforms[i].transform.position.x < playerTransform.position.x - destroyDistance)
            {
                Destroy(spawnedPlatforms[i]);
                spawnedPlatforms.RemoveAt(i);
                i--; // Adjust index after removing an element
            }
        }
    }
}
