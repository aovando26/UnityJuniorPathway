using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
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

            // Debug.Log("There are " + indexCount);
            // Debug.Log("You are pressing s");
            Instantiate((animalPrefabs[indexCount]) , new Vector3(0, 0, 20), animalPrefabs[indexCount].transform.rotation);
        }
    }
}
