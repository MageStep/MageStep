using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public int score = 0;
    public int startingHealth = 3;
    public int health = 0;

    void Start()
    {
        health = startingHealth;
    }

    public void ChangeHealth(int by = -1)
    {
        health += by;
        if(health <= 0)
        {
            // game is over!
            // go to end screen, show last score and button to go to main menu
            // set Time.timeScale to 0 and show panel
        }
    }

    public void ChangeScore(int givenAmount = 1)
    {
        score += givenAmount;
    }
}
