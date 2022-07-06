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
        firstInfoText.text = "Eðer Katmanlarý Yanlýþ Yerleþtirirseniz " +
            "Sol Üstteki Gördüðünüz Haklarýnýzdan Birisi Kaybolacaktýr. " +
            "3 Yanlýþ Hakkýnýz Vardýr.";       
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
