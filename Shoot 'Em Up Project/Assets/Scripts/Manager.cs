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
        }

        Time.timeScale = 0f;
    }

    public void increaseScore()
    {
        currentScore++;
        ScoreNumberText.GetComponent<TextMeshProUGUI>().text = String.Format("{0:0000}", currentScore); ;
    }
}
