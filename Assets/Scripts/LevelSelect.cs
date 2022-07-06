using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void level3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void level4()
    {
        SceneManager.LoadScene("Level4");
    }
}
