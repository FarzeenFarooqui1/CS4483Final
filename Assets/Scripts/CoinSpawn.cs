using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    //basic enemy 
    public GameObject coin;


    public float maxX; public float minX; public float maxY; public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;



    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            //spawn meaning spawn enemy 
            Spawn();

            spawnTime = Time.time + timeBetweenSpawn;
        }
    }
    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(coin, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

    }


}
