using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataLinkTrigger : MonoBehaviour
{
    public ScoreScript scoreScript;
    public GameConroll GameControll;
    public GameObject DataLink;
    public Rigidbody rbdatalink;
    public ApplicationTrigger ApplicationTrigger;

    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "DataLink")
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
        if(theCollision.gameObject.tag =="DataLink")
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
        DataLink.transform.position = new Vector3(10, 0.7f, 4);
        rbdatalink.constraints = RigidbodyConstraints.FreezeAll;
        DataLink.transform.localScale = new Vector3(4.5f, 0.5f, 0.75f);
        this.transform.localScale = new Vector3(4.49f, 0.49f, 0.749f);
        scoreScript.Score = scoreScript.Score + 10;

    }
    IEnumerator destroycross()
    {
        yield return new WaitForSeconds(4);
        scoreScript.Score = scoreScript.Score - 10;
    }
}
