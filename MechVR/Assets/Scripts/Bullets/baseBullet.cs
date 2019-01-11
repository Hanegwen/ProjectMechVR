using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseBullet : MonoBehaviour
{
    float lifetime = 5;

    Rigidbody rigidbody;
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
    }

    void Lifetime()
    {
        lifetime -= Time.deltaTime;

        if(lifetime <= 0 )
        {
            Destroy(this.gameObject);
        }
    }
}
