using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float speed = 20f; // speed of bullet
    public int damage = 40; // damge of bullet
    public Rigidbody2D rb; // assest of bullet 
    void Start()
    {
        rb.velocity = transform.right * speed;// fire postion of projectile 


    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();// when projectiles make contact with the enemy 
        if (enemy != null)// if player hits enemy componet 
        {
            enemy.TakeDamage(damage);// enemy takes damge 
        }
        Destroy(gameObject); // enemy is destyroyed 
    }

}
