using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    baseEnemy EneimiesToSpawn;

    EnemyManager enemyManager;
    // Start is called before the first frame update
    void Start()
    {
        enemyManager = FindObjectOfType<EnemyManager>();
        enemyManager.spawners.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        SpawnEnemy(EneimiesToSpawn);
    }

    public void SpawnEnemy(baseEnemy Enemy)
    {
        print("NOT DONE: SPAWN ENEMY HERE");
    }

    private void OnDestroy()
    {
        enemyManager.spawners.Remove(this);
    }
}
