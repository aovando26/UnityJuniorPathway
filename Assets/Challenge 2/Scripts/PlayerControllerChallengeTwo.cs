using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerChallengeTwo : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canSpawn = true; // Flag to track whether spawning is allowed

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog if allowed
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            StartCoroutine(SpawnDog());
        }
    }

    IEnumerator SpawnDog()
    {
        // Set the flag to false to prevent additional spawns
        canSpawn = false;

        // Instantiate the dog
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        // Wait for 3 seconds
        yield return new WaitForSeconds(1.5f);

        // Set the flag back to true to allow future spawns
        canSpawn = true;
    }
}
