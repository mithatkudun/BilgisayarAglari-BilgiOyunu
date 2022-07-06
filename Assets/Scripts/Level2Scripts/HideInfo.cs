using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using TMPro;

public class HideInfo : MonoBehaviour
{
    public GameObject Panel;
    public TMP_Text firstInfoText;
     void Start()
    {
        StartCoroutine("ChangeText");
    }
    IEnumerator DestroyPanel()
    {
        yield return new WaitForSeconds(7);
        Panel.SetActive(false);       
    }
    IEnumerator ChangeText()
    {
        yield return new WaitForSeconds(7);
        firstInfoText.text = "E�er Katmanlar� Yanl�� Yerle�tirirseniz " +
            "Sol �stteki G�rd���n�z Haklar�n�zdan Birisi Kaybolacakt�r. " +
            "3 Yanl�� Hakk�n�z Vard�r.";       
        StartCoroutine("DestroyPanel");
    }
        

        
    
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            Panel.SetActive(false);
        }           
    }
}
