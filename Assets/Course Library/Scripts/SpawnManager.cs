using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float _spawnPosX = 20;
    private float _spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.2f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int _animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-_spawnPosX, _spawnPosX), 0, _spawnPosZ);

        Instantiate(animalPrefabs[_animalIndex], spawnPos, animalPrefabs[_animalIndex].transform.rotation);
    }
}
