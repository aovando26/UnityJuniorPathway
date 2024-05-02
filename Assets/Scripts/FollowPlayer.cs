using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    Vector3 offset; 
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0.0f, 5.0f, -7.0f);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // assgins player's position to camera
        gameObject.transform.position = player.transform.position + offset;
    }
}
