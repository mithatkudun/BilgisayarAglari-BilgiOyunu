using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggertwo : MonoBehaviour
{
    public ScoreScript scoreScript;
    public GameControllerr GameControllerr;
    public GameObject client5;
    public Rigidbody2D rbclient5;
    public triggerone triggerone;

     void Start()
    {
        rbclient5.constraints = RigidbodyConstraints2D.FreezeAll;
    }
     void Update()
    {
        if(GameControllerr.counter > 0)
        {
            rbclient5.constraints = RigidbodyConstraints2D.None;
            rbclient5.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        if (GameControllerr.counter > 1)
        {
            rbclient5.constraints = RigidbodyConstraints2D.FreezeAll;
        }

    }
    void OnTriggerEnter2D(Collider2D theCollision2D)
    {
        if (theCollision2D.gameObject.tag == "client5")
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
        if (theCollision2D.gameObject.tag == "client5")
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
        client5.transform.position = new Vector3(0f, 12f, 0.51f);
        rbclient5.constraints = RigidbodyConstraints2D.FreezeAll;
        scoreScript.Score = scoreScript.Score + 20;

    }
    IEnumerator destroycross()
    {
        yield return new WaitForSeconds(3f);
        scoreScript.Score = scoreScript.Score - 20;
    }
}
