using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    //public variable 
    public Text ScoreDisplay;
    public bool shouldReset = false;
    public int winningScore;
    public string winningScene;
    //private variables 
    private static int scoreValue = 0;
    
    // function add to player score

    void Start()
    {
        // check to see if score should be reset
        if (shouldReset == true)
        {
            scoreValue = 0;
        }
        ScoreDisplay.text = scoreValue.ToString();
    }
    public void AddScore(int toAdd)
    {
        scoreValue = scoreValue + toAdd;
        // update score value

        //update score based on value
        ScoreDisplay.text = scoreValue.ToString();

        //check if the score is bigger than our win score
        if (scoreValue >= winningScore)
        {
            SceneManager.LoadScene(winningScene);
        }
    }
}
