using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI healthText;
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
            //save the current score
            PlayerPrefs.SetInt("Score", score);
            SceneManager.LoadScene("GameOver");
            // go to end screen, show last score and button to go to main menu or a button to restart
            
            // set Time.timeScale to 0 and show panel
        }
    }

    public void ChangeScore(int givenAmount = 1)
    {
        score += givenAmount;
    }

    void Update()
    {
        healthText.text = "Health: " + health;
        currentScoreText.text = "Score: " + score;
    }
}
