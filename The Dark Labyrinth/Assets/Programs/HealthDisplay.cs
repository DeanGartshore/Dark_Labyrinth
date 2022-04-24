using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    // contains list of game object for health icons
    public GameObject[] healthIcons;
    // contains player health component 
    PlayerHealth player;

    // Start is called before the first frame update
    void Start()
    {
        // serches scene for object with player health and stores player health component
        player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        // use varible to keep track of items in list and how much health that icon is worth
        int iconHealth = 0;
        // gose through list will do everthing inside brackets for each item on the list
        foreach (GameObject icon in healthIcons) 
        {
            // each icon is worth one more health than the last
            iconHealth = iconHealth + 1;

            // If the player current health is equal or greater 
            // than the health value for this icon
            
            if (player.GetHealth() >= iconHealth) 
            {
                // if true then turn icon on
                icon.SetActive(true);
                
            }
            // otherwise health is less than icons value
            else 
            {
                // icon turns offf
                icon.SetActive(false);
            }
        
        }
    }
}
