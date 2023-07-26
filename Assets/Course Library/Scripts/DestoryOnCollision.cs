using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOnCollision : MonoBehaviour
{

    private void OnTriggerEnter(Collider any)
    {
        Destroy(gameObject);
        Destroy(any.gameObject);
    }

}


