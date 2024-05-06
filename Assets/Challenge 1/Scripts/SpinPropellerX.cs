using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 200.0f; // Adjust this value in the Unity Editor

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller around its local z-axis with the specified speed
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
