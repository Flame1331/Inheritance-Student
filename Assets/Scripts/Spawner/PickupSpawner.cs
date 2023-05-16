using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public GameObject[] pickups;

    public float SpawnDuration;

    static public float maxSpawns = 4;
    static public float Spawncount = 0;


    private void Start()
    {
        StartCoroutine(Spawning());
    }


    IEnumerator Spawning()
    {
        yield return new WaitForSeconds(SpawnDuration);
        Vector3 spawn = new Vector3(Random.Range(-15, 12), Random.Range(-7, 12), transform.position.z);
        if(Spawncount <= maxSpawns)
        {
            Instantiate(pickups[Random.Range(0, pickups.Length)], spawn, transform.rotation);
            Spawncount++;
            Debug.Log("Added Count: " + Spawncount);
        }
        Debug.Log("Max Spawned: " + Spawncount);
        StartCoroutine(Spawning());
    }

}
