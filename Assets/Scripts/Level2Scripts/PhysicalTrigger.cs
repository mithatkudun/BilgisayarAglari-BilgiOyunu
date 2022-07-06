using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PhysicalTrigger : MonoBehaviour
{
    public ScoreScript scoreScript;
    public GameConroll GameControll;
    public GameObject Physical;
    public Rigidbody rbphysical;
    public ApplicationTrigger ApplicationTrigger;
    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Physical")
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
        if(theCollision.gameObject.tag =="Physical")
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
        Physical.transform.position = new Vector3(10, 0.7f, 6);
        rbphysical.constraints = RigidbodyConstraints.FreezeAll;
        Physical.transform.localScale = new Vector3(4, 0.5f, 0.7f);
        this.transform.localScale = new Vector3(3.99f, 0.49f, 0.69f);
        scoreScript.Score = scoreScript.Score + 10;
    }
    IEnumerator destroycross()
    {
        yield return new WaitForSeconds(4);
        scoreScript.Score = scoreScript.Score - 10;
    }
}
