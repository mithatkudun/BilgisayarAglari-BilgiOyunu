using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public ScoreScript scoreScript;
    public bool isCorrect = false;
    public QuizManager quizManager;
public void Answer()
    {
        if(isCorrect)
        {
            scoreScript.Score = scoreScript.Score + 30;
            quizManager.correct();
        }
        else
        {
            scoreScript.Score = scoreScript.Score - 30;
            quizManager.correct();
        }
    }
}
