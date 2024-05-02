using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed;
    private float turnSpeed;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        speed = 20.0f;
        turnSpeed = 25.0f;
        horizontalInput = 60.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // moving truck forward (along z-axis)
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
