using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private int MaxSpawnCount;

    private int counter = 0;
    private int spawnCounter = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (spawnCounter >= MaxSpawnCount)
        {
            return;
        }

        counter++;
        if (counter % 30 == 0)
        {
            counter = 0;
            Instantiate(EnemyPrefab, transform, false);
            spawnCounter++;
        }
    }
}