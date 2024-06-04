using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float maxUpper = 30f;
    private float minLower = 27.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // grabbing max z position 
        if (transform.position.z > maxUpper)
        {
            Destroy(gameObject);
        }
        // if lower bounds holds true 
        else if (transform.position.z < -minLower)
        {
         //    Debug.Log(transform.position.z);
            Destroy(gameObject);
        }
    }
}
