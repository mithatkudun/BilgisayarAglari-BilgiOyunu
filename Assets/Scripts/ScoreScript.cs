using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class ScoreScript : MonoBehaviour
{
    public int Score;
    public TMP_Text ScoreText;
    void Start()
    {   

        Score = PlayerPrefs.GetInt("Score");
        ScoreText.text = PlayerPrefs.GetInt("Score", 0).ToString();
    }
    void Update()
    {        
        ScoreText.text = "Skor = " + Score.ToString();
        PlayerPrefs.SetInt("Score", Score);

        if (Score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Score);            
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
        {
            PlayerPrefs.DeleteKey("Score");
        }
    }
}
