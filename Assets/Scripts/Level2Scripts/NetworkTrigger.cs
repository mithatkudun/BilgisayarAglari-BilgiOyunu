using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NetworkTrigger : MonoBehaviour
{
    public ScoreScript scoreScript;
    public GameConroll GameControll;
    public GameObject Network;
    public Rigidbody rbnetwork;
    public ApplicationTrigger ApplicationTrigger;
    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Network")
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
        if(theCollision.gameObject.tag =="Network")
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
        Network.transform.position = new Vector3(10, 0.7f, 2);
        rbnetwork.constraints = RigidbodyConstraints.FreezeAll;
        Network.transform.localScale = new Vector3(5, 0.5f, 0.8f);
        this.transform.localScale = new Vector3(4.99f, 0.49f, 0.79f);
        scoreScript.Score = scoreScript.Score + 10;

    }
    IEnumerator destroycross()
    {
        yield return new WaitForSeconds(4);
        scoreScript.Score = scoreScript.Score - 10;
    }
}
