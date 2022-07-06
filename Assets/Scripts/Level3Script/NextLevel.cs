using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject FinishGamePanel;
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine("NextLevell");
    }
    IEnumerator NextLevell()
    {
        yield return new WaitForSeconds(3);
        FinishGamePanel.SetActive(true);
    }
}
