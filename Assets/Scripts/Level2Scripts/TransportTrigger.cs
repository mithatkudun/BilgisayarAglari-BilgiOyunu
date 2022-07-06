using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransportTrigger : MonoBehaviour
{
    public ScoreScript scoreScript;
    public GameConroll GameControll;
    public GameObject Transport;
    public Rigidbody rbtransport;
    public ApplicationTrigger ApplicationTrigger;

    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Transport")
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
        if(theCollision.gameObject.tag =="Transport")
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
        Transport.transform.position = new Vector3(10, 0.7f, 0);
        rbtransport.constraints = RigidbodyConstraints.FreezeAll;
        Transport.transform.localScale = new Vector3(5.5f, 0.5f, 0.85f);
        this.transform.localScale = new Vector3(5.49f, 0.49f, 0.849f);
        scoreScript.Score = scoreScript.Score + 10;

    }
    IEnumerator destroycross()
    {
        yield return new WaitForSeconds(4);
        scoreScript.Score = scoreScript.Score - 10;

    }
}
