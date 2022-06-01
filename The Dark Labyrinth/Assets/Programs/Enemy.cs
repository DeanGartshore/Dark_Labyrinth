using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100; // enemy health set to 100

    public GameObject deathEffect;
    public void TakeDamage (int damage)
    {
       
        health -= damage;

        if (health <= 0) // enemy dies if health reaches 0 
        {
            Die();
        }



    }
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject); // death effect will be displayed 
    }
}
