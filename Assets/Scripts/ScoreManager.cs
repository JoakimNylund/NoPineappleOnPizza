using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public bool BossHit { get; set; }
    public int Score { get; set; }
    
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            displayScore();
        }
        checkHighScore();
    }
    private void Start()
    {
        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        InvokeRepeating("AddScore", 1, 1);
    }

    public void displayScore()
    {
        scoreText.text = "Current: " + Score.ToString();
    }

    void AddScore()
    {
        Score += 1;
    }

    public void ScoreUp()
    {
        Score += 100;
        Debug.Log(Score);
    }

    public void checkHighScore()
    {
        if (Score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Score);
            highScoreText.text = "Highscore: " + Score.ToString();
        }
    }
}
