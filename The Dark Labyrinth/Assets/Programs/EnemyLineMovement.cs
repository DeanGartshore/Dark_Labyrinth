using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLineMovement : MonoBehaviour
{
    //Public variables list
    public float forceStrength; // speed of enemy movement
    public Vector2 direction; // direction of enemy movement 

    //Private variables list
    private Rigidbody2D ourRigidbody; // the container for rigidbody 

    void Awake()
    {
        // get and store rigidbody
        ourRigidbody = GetComponent<Rigidbody2D>();

        //normalise direction 
        // changes it to br length one 
        // multiply length by speed
        direction = direction.normalized;
    }


    // Update is called once per frame
    void Update()
    {
        //move in the set force direction with set firced strength
        ourRigidbody.AddForce(direction * forceStrength);

    }
}
