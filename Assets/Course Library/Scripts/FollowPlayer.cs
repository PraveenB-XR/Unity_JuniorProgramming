using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public Vector3 offset = Vector3.zero;
    

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position+ offset;

    }
}
