using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire3 : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            Shoot();
        }




        void Shoot()
        {

            Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);

            Animator playerAnimator;
            playerAnimator = GetComponent<Animator>();
            playerAnimator.SetTrigger("UpwardAttack");

        }
    }
}
