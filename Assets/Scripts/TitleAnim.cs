using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleAnim : MonoBehaviour
{
    public float tweenTime;
    void Start()
    {
        TweenTitle();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TweenTitle()
    {
        LeanTween.cancel(gameObject);

        transform.localScale = Vector3.one;

        LeanTween.scale(gameObject, Vector3.one * 2, tweenTime).setEasePunch();
    }

}
