using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<EnemySpawner> spawners;
    EnemySpawner lastSpawnerUsed;
    EnemySpawner nextSpawnerToUse;

    float spawnRecharge = .5f;
    bool canSpawn = true;

    [SerializeField]
    List<baseEnemy> listOfEnemies;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy(EnemySpawner WhereToSpawn)
    {
        print("NOT DONE: SPAWN DEFAULY ENEMY");
        canSpawn = false;
    }

    void SpawnEnemy(EnemySpawner WhereToSpawn, baseEnemy enemyToSend)
    {
        print("NOT DONE: SPAWN SENT ENEMY");
        canSpawn = false;
    }

    IEnumerator SpawnDelay()
    {
        yield return new WaitForSeconds(spawnRecharge);
        canSpawn = true;
    }
}
