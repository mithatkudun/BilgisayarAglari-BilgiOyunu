using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameConroll : MonoBehaviour
{
    public int counter;
    public GameObject FinishGamePanel;
    void Update()
    {
        if (counter > 6)
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
