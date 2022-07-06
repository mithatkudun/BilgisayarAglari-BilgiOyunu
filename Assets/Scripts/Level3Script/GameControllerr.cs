using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControllerr : MonoBehaviour
{
    public int counter;
    public GameObject FinishGamePanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter > 5)
        {
            StartCoroutine("nextlevel");
        }
    }
    IEnumerator nextlevel()
    {
        yield return new WaitForSeconds(3);
        FinishGamePanel.SetActive(true);
    }
}
