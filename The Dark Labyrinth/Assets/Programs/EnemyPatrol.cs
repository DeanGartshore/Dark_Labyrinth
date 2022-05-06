using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    // public varibles
    public float forceStrength; // how fast enemy moves
    public Vector2[] patrolPoints; // patrol points enemy moves to 
    public float stopDistance; // how close we get before moving to next patrol point
    private Rigidbody2D ourRigidbody; // the rigidbody on this object used to move
    private int currentPoint = 0; // index of the current point

    // called when the script is loaded 
    void Awake()
    {
        // attach rigidbody for movement 
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float distance = (patrolPoints[currentPoint] - (Vector2)transform.position).magnitude;

        if (distance <= stopDistance) 
        {

            currentPoint = currentPoint + 1;

            if (currentPoint >= patrolPoints.Length) 
            {




                currentPoint = 0;
            }
        
        }

        // move in the direction of target
        // get direction to move in
        // subtraction the current position
        Vector2 direction = patrolPoints[currentPoint] - (Vector2)transform.position;
        direction = direction.normalized;


        ourRigidbody.AddForce(direction * forceStrength);

    }
}
