using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Enemy[] enemies;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, enemies.Length);
        Instantiate(enemies[randomIndex], transform.position, transform.rotation);
    }
}
