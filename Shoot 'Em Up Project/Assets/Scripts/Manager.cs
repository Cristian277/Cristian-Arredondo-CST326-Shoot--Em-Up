using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [Header("Score UI")]
    public GameObject ScoreNumberText;
    public GameObject HI_SCORE_TEXT;
    int highScore = 0;
    int currentScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        HI_SCORE_TEXT.GetComponent<TextMeshProUGUI>().text = String.Format("{0:0000}", PlayerPrefs.GetInt("High Score"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver()
    {
        Debug.Log("Game Over");

        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("High Score", highScore);
            HI_SCORE_TEXT.GetComponent<TextMeshProUGUI>().text = String.Format("{0:0000}", PlayerPrefs.GetInt("High Score"));
        }

        Time.timeScale = 0f;
    }

    public void increaseScoreRed()
    {
        currentScore+=60;
        ScoreNumberText.GetComponent<TextMeshProUGUI>().text = String.Format("{0:0000}", currentScore); ;
    }
    public void increaseScoreBlue()
    {
        currentScore+=30;
        ScoreNumberText.GetComponent<TextMeshProUGUI>().text = String.Format("{0:0000}", currentScore); ;
    }
    public void increaseScoreGreen()
    {
        currentScore+=20;
        ScoreNumberText.GetComponent<TextMeshProUGUI>().text = String.Format("{0:0000}", currentScore); ;
    }
    public void increaseScoreYellow()
    {
        currentScore+=10;
        ScoreNumberText.GetComponent<TextMeshProUGUI>().text = String.Format("{0:0000}", currentScore); ;
    }
}
