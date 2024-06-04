using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private int intervalOfX = 16;
    private int spawnPosZ = 10; 
   //  public int animalIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int indexCount = Random.Range(0, animalPrefabs.Length);

            // ONLY WOULD LIKE TO RANDOMIZE transform.position.x & transform.position.z
            int randomX = Random.Range(-intervalOfX, intervalOfX);

            Debug.Log("Random z coodinate: " + randomX);

            Vector3 spawnPos = new Vector3(randomX, 0, spawnPosZ);
            // Debug.Log("There are " + indexCount);
            // Debug.Log("You are pressing s");
            Instantiate((animalPrefabs[indexCount]) , spawnPos, animalPrefabs[indexCount].transform.rotation);
        }
    }
}
