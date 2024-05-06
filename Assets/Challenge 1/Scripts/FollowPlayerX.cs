using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    // takes plane gameobject
    public GameObject plane;

    // creates offset storing what coordinates? 
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(30.0f, 0.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // gameobject (mainCamera) takes the position of plane with offsets
        transform.position = plane.transform.position + offset;
    }
}
