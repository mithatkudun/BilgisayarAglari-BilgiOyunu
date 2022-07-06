using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LastScene : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        PlayerPrefs.SetString("_last_scene_", scene.name);
    }
    public static void LoadLastScene()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("_last_scene_"));
    }
}
