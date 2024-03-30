using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    public float enemySpeed; // Add this variable to control enemy speed
    private float spawnTime;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        GameObject newObstacle = Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

        // Access the Enemy component of the instantiated object and set its speed
        Enemy enemyScript = newObstacle.GetComponent<Enemy>();
        if (enemyScript != null)
        {
            enemyScript.speed = enemySpeed;
        }
    }
}
