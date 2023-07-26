using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -18;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {

        Invoke("SpawnRandomBall", startDelay);

    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        int RandomSpawnBall = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[RandomSpawnBall], spawnPos, ballPrefabs[RandomSpawnBall].transform.rotation);

        // we are randoming inside this so we can call this method
        spawnInterval = Random.Range(1, 4);
        //Debugging to check spawninterval seconds changing 
        Debug.Log(spawnInterval);


        Invoke("SpawnRandomBall", spawnInterval);

    }



}
