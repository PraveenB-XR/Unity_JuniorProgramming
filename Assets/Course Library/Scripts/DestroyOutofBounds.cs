using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    public float topBound;
    public float bottomBound;
    public GameObject DisablePlayer;
    // Update is called once per frame
    void Update()
    {

        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound)
        {
            Debug.Log("GameOver");

            Destroy(gameObject);
            //Destroy(DisablePlayer);
        }

    }
}
