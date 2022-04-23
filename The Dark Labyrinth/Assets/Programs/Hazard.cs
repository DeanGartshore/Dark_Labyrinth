using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
    // function handles collisions 
    // function will be called when an object bumbs into the player
{
    public int hazardDamage;

    private void OnCollisionEnter2D(Collision2D collisionData)
    {
        //get the object player collides with 
        Collider2D objectWeCollidedWith = collisionData.collider;

        //attach player health to that object
        PlayerHealth player = objectWeCollidedWith.GetComponent<PlayerHealth>();
        // check if the player has collieded with object 
        if (player != null) 
        {
            // this means there was a player health script attached to the object of collider
            // there action will be performed 
            player.ChangeHealth(-hazardDamage);
        }
    }
}
