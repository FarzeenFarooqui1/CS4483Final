using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject coinSpawner;
    public GameObject obstacleSpawner;
    public GameObject enemySpawner;
    public GameObject powerupSpawner;

    public float activateObstacles;
    public float activateEnemy;
    public float activatePowerup;
    
    // Start is called before the first frame update
    void Start()
    {
        coinSpawner.SetActive(true);
        obstacleSpawner.SetActive(false);
        enemySpawner.SetActive(false);
        powerupSpawner.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > activateObstacles)
        {
            obstacleSpawner.SetActive (true);
        }
        if (Time.timeSinceLevelLoad > activateEnemy)
        {
            enemySpawner.SetActive(true);
        }
        if (Time.timeSinceLevelLoad > activatePowerup)
        {
            powerupSpawner.SetActive(true);
        }
    }
}
