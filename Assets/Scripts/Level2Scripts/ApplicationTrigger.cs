using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplicationTrigger : MonoBehaviour
{
    public ScoreScript scoreScript;
    public GameConroll GameControll;
    public GameObject Application;
    public Rigidbody rbapplication;

    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Application")
        {
            StartCoroutine("triggerenter");
        }
        else
        {
            StartCoroutine("destroycross");
        }
    }
    void OnTriggerExit(Collider theCollision)
    {
        if(theCollision.gameObject.tag =="Application")
        {
            StopCoroutine("triggerenter");
        }
        else
        {
            StopCoroutine("destroycross");
        }
    }
    IEnumerator triggerenter()
    {   
        yield return new WaitForSeconds(4);
        GameControll.counter = GameControll.counter + 1;
        Application.transform.position = new Vector3(10, 0.7f, -6);
        rbapplication.constraints = RigidbodyConstraints.FreezeAll;
        Application.transform.localScale = new Vector3(7, 0.5f, 1f);
        this.transform.localScale = new Vector3(6.99f, 0.49f, 0.99f);
        scoreScript.Score = scoreScript.Score + 10;

    }
    IEnumerator destroycross()
    {
        yield return new WaitForSeconds(4);
        scoreScript.Score = scoreScript.Score - 10;
    }
}
