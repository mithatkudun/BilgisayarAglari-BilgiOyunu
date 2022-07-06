using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour

{   
    public ScoreScript scoreScript;
    public GameObject TitleMenu;
    public GameObject SelectLevelMenu;
    public GameObject OptionsMenu;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Reset();
    }
    public void LevelSelectButton()
    {
        LeanTween.scale(TitleMenu, Vector3.zero, 1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.scale(SelectLevelMenu, Vector3.one, 1f).setEase(LeanTweenType.easeInOutBack);
        SelectLevelMenu.SetActive(true);
    }
    public void OptionsButton()
    {
        LeanTween.scale(TitleMenu, Vector3.zero, 1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.scale(OptionsMenu, Vector3.one, 1f).setEase(LeanTweenType.easeInOutBack);
        OptionsMenu.SetActive(true);
    }
    public void BackButtonOptions()
    {
        LeanTween.scale(OptionsMenu, Vector3.zero, 1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.scale(TitleMenu, Vector3.one, 1f).setEase(LeanTweenType.easeInOutBack);
        OptionsMenu.SetActive(false);
    }
    public void BackButtonLevelSelect()
    {
        LeanTween.scale(SelectLevelMenu, Vector3.zero, 1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.scale(TitleMenu, Vector3.one, 1f).setEase(LeanTweenType.easeInOutBack);
        SelectLevelMenu.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Reset()
    {
       
    }

}
   

