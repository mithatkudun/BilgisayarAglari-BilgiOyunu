using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerfive : MonoBehaviour
{
    public ScoreScript scoreScript;
    public GameControllerr GameControllerr;
    public GameObject client1;
    public Rigidbody2D rbclient1;
    public triggerone triggerone;

    void Start()
    {
        rbclient1.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    void Update()
    {
        if (GameControllerr.counter > 3)
        {
            rbclient1.constraints = RigidbodyConstraints2D.None;
            rbclient1.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        if (GameControllerr.counter > 4)
        {
            rbclient1.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
    void OnTriggerEnter2D(Collider2D theCollision2D)
    {
        if (theCollision2D.gameObject.tag == "client1")
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
        if (theCollision2D.gameObject.tag == "client1")
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
        client1.transform.position = new Vector3(8.98f, 10.15f, 0.51f);
        rbclient1.constraints = RigidbodyConstraints2D.FreezeAll;
        scoreScript.Score = scoreScript.Score + 20;

    }
    IEnumerator destroycross()
    {
        yield return new WaitForSeconds(3f);
        scoreScript.Score = scoreScript.Score - 20;
    }
}
