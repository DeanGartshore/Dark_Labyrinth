using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire2 : MonoBehaviour
{
    public Transform firepoint2;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();

            
        }




        void Shoot()
        {

            Instantiate(bulletPrefab, firepoint2.position, firepoint2.rotation);
            Animator playerAnimator;
            playerAnimator = GetComponent<Animator>();
            playerAnimator.SetTrigger("RightAttack");
        }
        
    }
    
}
