using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Enemy[] enemies;
    public float spawnDelay;

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, enemies.Length);
        Vector3 spawn = new Vector3(Random.Range(-15, 12), Random.Range(-7, 12), transform.position.z);
        if(Vector3.Distance(Player.transform.position, spawn) < 5)
        {
            spawn = new Vector3(Random.Range(-15, 12), Random.Range(-7, 12), transform.position.z);
        }
        else
        {
            Instantiate(enemies[randomIndex], spawn, transform.rotation);
        }
    }
}
