using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresentationTrigger : MonoBehaviour
{
    public ScoreScript scoreScript;
    public GameConroll GameControll;
    public GameObject Presentation;
    public Rigidbody rbpresentation;
    public ApplicationTrigger ApplicationTrigger;
    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Presentation")
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
        if(theCollision.gameObject.tag =="Presentation")
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
        Presentation.transform.position = new Vector3(10, 0.7f, -4);
        rbpresentation.constraints = RigidbodyConstraints.FreezeAll;
        Presentation.transform.localScale = new Vector3(6.5f, 0.5f, 0.95f);
        this.transform.localScale = new Vector3(6.49f, 0.49f, 0.949f);
        scoreScript.Score = scoreScript.Score + 10;

    }
    IEnumerator destroycross()
    {
        yield return new WaitForSeconds(4);
        scoreScript.Score = scoreScript.Score - 10;
    }
}
