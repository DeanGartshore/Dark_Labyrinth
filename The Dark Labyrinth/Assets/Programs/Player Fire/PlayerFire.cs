using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    public Transform firepoint;// the point the player fires from 
    public GameObject bulletPrefab;// the assest for the players bullet 

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // if the right button is pressed the player will shoot
        {
            Shoot();
        }


       

        void Shoot() {

            Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);// bullets will fire in direction that player firepoint is facing 
        
        }
    }
}
