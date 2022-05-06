using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire4 : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Shoot();
        }




        void Shoot()
        {

            Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);

        }
    }
}
