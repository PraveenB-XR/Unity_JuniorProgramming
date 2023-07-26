using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmPlayerController : MonoBehaviour
{
    public float HorizontalInput;
    public float speed = 10.0f;
    public int xLimit;
    public GameObject throwPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xLimit)
        {
            transform.position = new Vector3(-xLimit, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xLimit)
        {
            transform.position = new Vector3(xLimit, transform.position.y, transform.position.z);
        }


        HorizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(throwPrefab, transform.position, throwPrefab.transform.rotation);
        }
    }
}
