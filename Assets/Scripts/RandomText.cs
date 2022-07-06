using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomText : MonoBehaviour
{
    public TMP_Text[] txt;
    public List<string> TipList = new List<string>();
    public GameObject[] doorTriggers;
    Vector3 firstDoorTriggerleft =new Vector3 (-1.99f, 1.5f, 2.74f);
    Vector3 firstDoorTriggerright = new Vector3 (1.99f,1.5f, 2.74f);
    Vector3 secondDoorTriggerleft = new Vector3(-1.99f, 1.5f, 10.48f);
    Vector3 secondDoorTriggerright = new Vector3(1.99f, 1.5f, 10.48f);
    Vector3 thirdDoorTriggerleft = new Vector3(-1.99f, 1.5f, 17.48f);
    Vector3 thirdDoorTriggerright = new Vector3(1.99f, 1.5f, 17.48f);
    void Start()
        {
        randomtext();
        }

 

    void randomtext()
    {
        for (int i = 0; i < txt.Length; i++)
        {
            string tipChose = TipList[Random.Range(0, TipList.Count)];
            txt[i].text = tipChose;

        }
        if (txt[0].text == TipList[1] || txt[0].text == TipList[2] || txt[0].text == TipList[3] || txt[0].text == TipList[4] || txt[0].text == TipList[9])
        {
            doorTriggers[0].transform.position = firstDoorTriggerright;
            doorTriggers[1].transform.position = firstDoorTriggerleft;
        }
        if (txt[1].text == TipList[1] || txt[1].text == TipList[2] || txt[1].text == TipList[3] || txt[1].text == TipList[4] || txt[1].text == TipList[9])
        {
            doorTriggers[2].transform.position = secondDoorTriggerright;
            doorTriggers[3].transform.position = secondDoorTriggerleft;
        }
        if (txt[2].text == TipList[1] || txt[2].text == TipList[2] || txt[2].text == TipList[3] || txt[2].text == TipList[4] || txt[2].text == TipList[9])
        {
            doorTriggers[4].transform.position = thirdDoorTriggerright;
            doorTriggers[5].transform.position = thirdDoorTriggerleft;
        }

    }
    
}

