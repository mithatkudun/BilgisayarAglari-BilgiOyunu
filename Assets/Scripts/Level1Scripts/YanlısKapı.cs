using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YanlısKapı : MonoBehaviour
{
    public ScoreScript scoreScript;
    void Start()
    { 
    }
    private void OnTriggerEnter(Collider other)
    {
        
        StartCoroutine("Delay");      
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        scoreScript.Score = scoreScript.Score - 10;
        StopCoroutine("Delay");
    }
}
