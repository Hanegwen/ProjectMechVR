using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    baseBullet Bullet;

    [SerializeField]
    Transform gunLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("PC: SHOOTING WITH MOUSE");
            ShootQuickWeapon();
        }
    }

    void ShootQuickWeapon()
    {
        Instantiate(Bullet, gunLocation);
    }

    void ShootLongWeapon()
    {

    }
}
