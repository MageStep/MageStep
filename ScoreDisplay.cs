using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    private ScoreKeeper manager;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {

        int finalScore = PlayerPrefs.GetInt("Score");
        //manager = GameObject.Find("GameManager").GetComponent<ScoreKeeper>();
        scoreText.text = "Final Score: " + finalScore;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
