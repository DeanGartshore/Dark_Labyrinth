using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimeLimit : MonoBehaviour

{
    public float timeLimit; // how much time is avibale  
    public string gameOverScene; // to display if timer runs out

    private float startTime; // time the timer when started 
    private Text timerDisplay; // timer displayed on screen
    // Start is called before the first frame update
    void Start()
    {
        timerDisplay = GetComponent<Text>();// timer is displayed on screen by text 
        startTime = Time.time;// the start time is equal to the set time
    }

    // Update is called once per frame
    void Update()
    {
        float TimePassed = Time.time - startTime;// calculate how much time has passed

        timerDisplay.text = ((int)(timeLimit - TimePassed)).ToString();// display text at the start 

        if (TimePassed >= timeLimit)
        {


            SceneManager.LoadScene(gameOverScene);// if time runs out game gose to game over screen 
        
        }
    }
}
