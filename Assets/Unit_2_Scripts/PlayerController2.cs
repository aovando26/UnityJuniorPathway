using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 15.0f;
    public GameObject projectilePrefab; 
    // public bool isMoving = false;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pizza is spawning from player");
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); 
        }
    }
}
