using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> EneimiesToSpawn; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        SpawnEnemy(EneimiesToSpawn[0]);
    }

    public void SpawnEnemy(GameObject Enemy)
    {

    }
}
