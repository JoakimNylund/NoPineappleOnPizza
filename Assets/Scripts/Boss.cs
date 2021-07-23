
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    //The class Boss deals with spawning the boss of bad toppings, canned mushroom.
    public GameObject boss;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float spawnTime = 10f;
    public GameObject player;
    public ParticleSystem deathParticles;
    public GameObject scoreManager;
    public float obstacleRadius;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        scoreManager = GameObject.FindWithTag("Score");
        InvokeRepeating("Spawn", spawnTime, spawnTime); 
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Instantiate(boss, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "Border")
       {
            Destroy(this.gameObject);
       }
       else if (collision.tag == "Player")
       {
            //If the player collides with a mushroom can, we create cool particle effects.
            Vector3 position = new Vector3(transform.position.x, transform.position.y, -7);
            Instantiate(deathParticles, position, Quaternion.Euler(0, 120, 0));            
            scoreManager.GetComponent<ScoreManager>().ScoreUp();     
            Destroy(this.gameObject);
       }      

    }
}
