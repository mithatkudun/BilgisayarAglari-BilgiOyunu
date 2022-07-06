using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggersix : MonoBehaviour
{
    public ScoreScript scoreScript;
    public GameControllerr GameControllerr;
    public GameObject client3;
    public Rigidbody2D rbclient3;
    public triggerone triggerone;

    void Start()
    {
        rbclient3.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    void Update()
    {
        if (GameControllerr.counter > 4)
        {
            rbclient3.constraints = RigidbodyConstraints2D.None;
            rbclient3.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        if (GameControllerr.counter > 5)
        {
            rbclient3.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
    void OnTriggerEnter2D(Collider2D theCollision2D)
    {
        if (theCollision2D.gameObject.tag == "client3")
        {
            StartCoroutine("triggerenter");
        }
        else
        {
            StartCoroutine("destroycross");
        }
    }
    void OnTriggerExit2D(Collider2D theCollision2D)
    {
        if (theCollision2D.gameObject.tag == "client3")
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
        yield return new WaitForSeconds(0.1f);
        GameControllerr.counter = GameControllerr.counter + 1;
        client3.transform.position = new Vector3(9.07f, 4.16f, 0.51f);
        rbclient3.constraints = RigidbodyConstraints2D.FreezeAll;
        scoreScript.Score = scoreScript.Score + 20;

    }
    IEnumerator destroycross()
    {
        yield return new WaitForSeconds(3f);
        scoreScript.Score = scoreScript.Score - 20;
    }
}
