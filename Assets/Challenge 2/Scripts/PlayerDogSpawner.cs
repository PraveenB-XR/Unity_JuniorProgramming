using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDogSpawner : MonoBehaviour
{
    public GameObject dogPrefab;
    private float _waitTime;
    public float coolDown;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && _waitTime > coolDown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            _waitTime = 0;
        }

        if (_waitTime < coolDown)
        {
            _waitTime += 1 * Time.deltaTime;
        }
    }

}
