using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseBullet : MonoBehaviour
{
    float lifetime = 5;
    float movementSpeed = 100;
    int damage = 1;

    Rigidbody rigidbody;

    enum owners {player, enemy };
    owners myOwner;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Lifetime();
        MoveForward();
    }

    void MoveForward()
    {
        print("NOT CODED: Bullet Should be Moving Forward");
        rigidbody.velocity = Vector3.forward * Time.deltaTime * movementSpeed;
    }

    void Lifetime()
    {
        lifetime -= Time.deltaTime;

        if(lifetime <= 0 )
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<IDamagable>() != null)
        {
            if (other.gameObject.name.Contains("Player"))
            {
                if (myOwner == owners.enemy)
                {
                    other.gameObject.GetComponent<IDamagable>().TakeDamage(damage);
                    print("Bullet hits Player");
                }
            }
            else if (other.gameObject.name.Contains("Enemy"))
            {
                if (myOwner == owners.player)
                {
                    other.gameObject.GetComponent<IDamagable>().TakeDamage(damage);
                    print("Bullet hits Enemy");
                }
            }
        }
    }
}
