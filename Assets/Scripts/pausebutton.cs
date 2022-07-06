
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausebutton : MonoBehaviour
{
     void Start()
    {
        Time.timeScale = 1f;    
    }
   public void Mainmenu()
    {
        SceneManager.LoadScene(0);
    }
   public void resumebuton()
    {
        Time.timeScale = 1f;
    }
   public void  pausebuton()
    {
        Time.timeScale = 0f;
    }

    void Update()
    {
        
    }
}
