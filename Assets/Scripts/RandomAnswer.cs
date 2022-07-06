using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomAnswer : MonoBehaviour
{

    public TMP_Text[] txt;
    public TMP_Text[] answerTxt;  
    public List<string> answer1 = new List<string>();
    public List<string> TipList = new List<string>();
    

    void Start()
    {
        randomtext();
    }

    void randomtext()
    {
        for (int i = 0; i < txt.Length; i++)
        {
            string tipChose = TipList[Random.Range(0, TipList.Count) - 1];
            txt[i].text = tipChose;                      
        }        
    }
    void Update()
    {
        for (int i = 0; i < txt.Length; i++)
        {
          int  x = i;
            if(TipList[x] == txt[i].text)
            {
                
            }
             
        }
        
    }
}

