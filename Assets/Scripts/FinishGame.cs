using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishGame : MonoBehaviour
{
    public void nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void goMainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
