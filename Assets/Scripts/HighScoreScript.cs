using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreScript : MonoBehaviour
{
    public ScoreScript scoreScript;
    public TMP_Text HighScoreText;
    void Start()
    {
        HighScoreText.text = "En Yüksek Skor = " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    void Update()
    {
        if(scoreScript.Score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scoreScript.Score);
            HighScoreText.text = "En Yüksek Skor = " + scoreScript.Score.ToString();
        }
    }
}
