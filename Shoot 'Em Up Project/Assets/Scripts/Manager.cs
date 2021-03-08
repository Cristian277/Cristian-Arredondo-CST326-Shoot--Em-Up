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
    public GameObject WIN_TEXT;
    public GameObject GAME_OVER_TEXT;

    int highScore = 0;
    int currentScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        //WIN_TEXT.GetComponent<TextMeshProUGUI>().text = "";
        //GAME_OVER_TEXT.GetComponent<TextMeshProUGUI>().text = "";

        HI_SCORE_TEXT.GetComponent<TextMeshProUGUI>().text = String.Format("{0:0000}", PlayerPrefs.GetInt("HighScore"));
        highScore = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        if (currentScore > highScore)
        {
            highScore = currentScore;

            PlayerPrefs.SetInt("HighScore", highScore);

            HI_SCORE_TEXT.GetComponent<TextMeshProUGUI>().text = String.Format("{0:0000}", PlayerPrefs.GetInt("HighScore"));
        }
    }

    public void gameOver()
    {
        Debug.Log("Game Over");
        Debug.Log("Press R to Restart");

        //GAME_OVER_TEXT.GetComponent<TextMeshProUGUI>().text = "GAME OVER PRESS R TO RESTART";

        //HI_SCORE_TEXT.GetComponent<TextMeshProUGUI>().text = String.Format("{0:0000}", PlayerPrefs.GetInt("HighScore"));

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
