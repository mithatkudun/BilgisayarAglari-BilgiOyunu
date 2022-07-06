using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SessionTrigger : MonoBehaviour
{
    public ScoreScript scoreScript;
    public GameConroll GameControll;
    public GameObject Session;
    public Rigidbody rbsession;
    public ApplicationTrigger ApplicationTrigger;

    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Session")
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
        if(theCollision.gameObject.tag =="Session")
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
        Session.transform.position = new Vector3(10, 0.7f, -2f);
        rbsession.constraints = RigidbodyConstraints.FreezeAll;
        Session.transform.localScale = new Vector3(6, 0.5f, 0.90f);
        this.transform.localScale = new Vector3(5.99f, 0.49f, 0.899f);
        scoreScript.Score = scoreScript.Score + 10;

    }
    IEnumerator destroycross()
    {
        yield return new WaitForSeconds(4);
        scoreScript.Score = scoreScript.Score - 10;
    }
}
