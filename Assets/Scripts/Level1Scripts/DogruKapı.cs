using System.Collections;

using UnityEngine;


public class DogruKapı : MonoBehaviour
{
    public ScoreScript scoreScript;
    void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Delay(1));
        scoreScript.Score = scoreScript.Score + 10;
    }
    IEnumerator Delay(float duration)
    {
        yield return null;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
