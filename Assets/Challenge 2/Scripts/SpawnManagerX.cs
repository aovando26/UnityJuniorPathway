using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnTimer;
    private int spawnIntervalLower = 1;
    private int spawnIntervaUpper = 5;

    private float lastSpawnedTime;
    private float currentSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        // Ensures balls start to spawn after specific start delay.
        spawnTimer = startDelay;

        // Capture time of start for PrintTimeSinceLastSpawn method - debugging tool.
        currentSpawnTime = Time.time;
    }

    private void Update()
    {
        // Ticks down timer by real time passed per frame.
        spawnTimer -= Time.deltaTime;

        // When timer reaches zero or below, spawn the ball and reset the timer to new random integer.
        if (spawnTimer <= 0)
        {
            SpawnRandomBall();
            PrintTimeSinceLastSpawn();
            spawnTimer = Random.Range(spawnIntervalLower, spawnIntervaUpper + 1);
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        int randomBallIndex = UnityEngine.Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBallIndex], spawnPos, ballPrefabs[randomBallIndex].transform.rotation);
    }

    // Deugging tool for checking that time between ball spawns was working correctly - to be called whenever a ball is spawned.
    void PrintTimeSinceLastSpawn()
    {
        lastSpawnedTime = currentSpawnTime;
        currentSpawnTime = Time.time;
        Debug.Log($"Time since last spawn and current: {Mathf.Round(currentSpawnTime - lastSpawnedTime)}");
    }
}