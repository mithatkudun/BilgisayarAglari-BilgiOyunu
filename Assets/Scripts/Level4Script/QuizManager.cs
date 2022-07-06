using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    public GameObject Panel;
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public GameObject FinishPanel;
    public TMP_Text QuestionTxt;

    private void Start()
    {
        
        generateQuestion();
    }
    public void correct()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }
    void SetAnswers()
    {
        for (int i = 0; i <options.Length; i++)
        {
            options[i].transform.GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = QnA[currentQuestion].Answers[i];
            if(QnA[currentQuestion].CorrectAnswer ==i +1)
            {
                options[i].transform.GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
    void generateQuestion()
    {   
        if(QnA.Count > 9)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Panel.SetActive(false);
            FinishPanel.SetActive(true);
            Debug.Log("no Q");
        }

       
    }
}
