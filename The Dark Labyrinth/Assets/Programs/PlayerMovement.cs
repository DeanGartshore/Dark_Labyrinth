using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public varibles 
    public float moveSpeed = 5f; // speed of player movement
    public Rigidbody2D rb; // refrence to Rigidbody
    public Animator animatior;// refrence to Animator
    Vector2 movement;// varible transfers data from update to fixed update function




    // Update is called once per frame
    void Update()//input function
    {
        // these lines get input of player movement for diffrent dimentions
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animatior.SetFloat("Horizontal", movement.x);
        animatior.SetFloat("Vertical", movement.y);
        animatior.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()// movement function
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);// moves the rigidbody to a new position and makes sure it dose not collide with anything
    }
}
