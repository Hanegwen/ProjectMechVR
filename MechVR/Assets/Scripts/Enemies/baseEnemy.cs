using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseEnemy : MonoBehaviour, IDamagable
{
    EnemyAttack enemyAttack;
    EnemyMovement enemyMovement;

    [SerializeField]
    int health = 1;

    enum TypeofEnemy { Shooter, Suicider};
    [SerializeField]
    TypeofEnemy myType;

    float delayForThoughts = .1f;
    bool canMakeANewDecision = true;
    // Start is called before the first frame update
    void Start()
    {
        enemyAttack = GetComponent<EnemyAttack>();
        enemyMovement = GetComponent<EnemyMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Die()
    {
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Die();
    }

    IEnumerator DelayToMakeDecision()
    {
        yield return new WaitForSeconds(delayForThoughts);
        canMakeANewDecision = true;

    }

}
