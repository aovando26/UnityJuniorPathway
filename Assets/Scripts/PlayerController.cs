using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // moving truck forward (along z-axis)
        // transform.Translate(0, 0, speed * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * Time.deltaTime); 
    }
}
