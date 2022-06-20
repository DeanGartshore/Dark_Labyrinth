using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void PlayGame() 
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Intro Level");

        }

          
    
    
    }
}
