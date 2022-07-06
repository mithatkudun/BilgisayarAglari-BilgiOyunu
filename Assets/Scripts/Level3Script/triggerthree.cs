using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerthree : MonoBehaviour
{
    public ScoreScript scoreScript;
    public GameControllerr GameControllerr;
    public GameObject client2;
    public Rigidbody2D rbclient2;
    public triggerone triggerone;
    void Start()
    {
        rbclient2.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    void Update()
    {
        if (GameControllerr.counter > 1)
        {
            rbclient2.constraints = RigidbodyConstraints2D.None;
            rbclient2.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        if (GameControllerr.counter > 2)
        {
            rbclient2.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

    void OnTriggerEnter2D(Collider2D theCollision2D)
    {
        if (theCollision2D.gameObject.tag == "client2")
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
        if (theCollision2D.gameObject.tag == "client2")
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
        client2.transform.position = new Vector3(-8.88f, 8.58f, 0.51f);
        rbclient2.constraints = RigidbodyConstraints2D.FreezeAll;
        scoreScript.Score = scoreScript.Score + 20;

    }
    IEnumerator destroycross()
    {
        yield return new WaitForSeconds(3f);
        scoreScript.Score = scoreScript.Score - 20;
    }
}
