using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // varible for the players health at the beginning 
    public int startingHealth;

    int currentHealth;
    // the players current health

    // built in unity function called when the script is created 
    void Awake()
    {
        //initialise our current health to be equal to our starting health at beginning of game
        currentHealth = startingHealth;
    }

    public void ChangeHealth(int changeAmount) 
    {
        // this function changes player health and kills them if it reaches 0
        currentHealth = currentHealth + changeAmount;
        // take current health and change amount then store it in current variable 
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);
        // keep health between 0 and starting health 
        
        // if our health drops to 0 player must die
        if (currentHealth == 0) 
        {
            // call the kill function to kill player 
            Kill();
        
        
        }
    
    }
    // non unity bulit function can only be called manually
    public void Kill() 
    {
        // this will destroy the game object
        Destroy(gameObject);
    }

    public int GetHealth() 
    {

       return currentHealth;
    
    
    }
}
