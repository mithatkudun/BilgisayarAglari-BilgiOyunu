using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerfour : MonoBehaviour
{
    public ScoreScript scoreScript;
    public GameControllerr GameControllerr;
    public GameObject client4;
    public Rigidbody2D rbclient4;
    public triggerone triggerone;

    void Start()
    {
        rbclient4.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    void Update()
    {
        if (GameControllerr.counter > 2)
        {
            rbclient4.constraints = RigidbodyConstraints2D.None;
            rbclient4.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        if (GameControllerr.counter > 3)
        {
            rbclient4.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
    void OnTriggerEnter2D(Collider2D theCollision2D)
    {
        if (theCollision2D.gameObject.tag == "client4")
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
        if (theCollision2D.gameObject.tag == "client4")
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
        client4.transform.position = new Vector3(9.04f, 7.26f, 0.51f);
        rbclient4.constraints = RigidbodyConstraints2D.FreezeAll;
        scoreScript.Score = scoreScript.Score + 20;

    }
    IEnumerator destroycross()
    {
        yield return new WaitForSeconds(3f);
        scoreScript.Score = scoreScript.Score - 20;
    }
}