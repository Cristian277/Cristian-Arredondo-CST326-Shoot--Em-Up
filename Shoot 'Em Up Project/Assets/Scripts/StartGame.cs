using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [Header("Score UI")]
    public GameObject ScoreNumberText;
    public GameObject HI_SCORE_TEXT;

    // Start is called before the first frame update
    void Start()
    {
        HI_SCORE_TEXT.GetComponent<TextMeshProUGUI>().text = String.Format("{0:0000}", PlayerPrefs.GetInt("High Score"));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene(1);
        }
    }
}
