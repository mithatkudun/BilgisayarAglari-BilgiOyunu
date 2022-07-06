
using UnityEngine;
using UnityEngine.UI;

public class sonkapı : MonoBehaviour
{
    public Text inforfornextlevel;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        inforfornextlevel.gameObject.SetActive(true);
    }
    void Update()
    {
        
    }
}
