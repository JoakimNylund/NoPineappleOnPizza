using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    public float spawnTime;
    public ScoreManager scoreManager;
    public float spawnTimer = 1f;

    private void Start()
    {
       InvokeRepeating("Spawn", 1.0f, 0.4f);
       //Spawns obstacles with 1.0f and 0.4f frequency.
    }

    void Spawn()
    {
        //This method randomizes and spawns new enemies.
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
