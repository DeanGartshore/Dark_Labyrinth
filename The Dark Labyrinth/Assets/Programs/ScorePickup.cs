using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour
{

    //public variable
    public int pickupvalue = 1;

    //function called when object overlap
    // the condintion if player touches coin
    void OnTriggerEnter2D(Collider2D other)
    {
        // check if the score script is attached to collision object
        Score scoreScript = other.GetComponent<Score>();

        if (scoreScript != null)
        {
            // add pick up value to players current score
            scoreScript.AddScore(pickupvalue);

            // we should destroy then delete this object so we don't infinitely add score
            Destroy(gameObject);
        }
    }
}
