
using UnityEngine;



public class DoorTrigger : MonoBehaviour
{
    public GameObject Door1;
    public bool doorIsOpening;
    void Start()
    {

    }
    void Update()
    {
        if (doorIsOpening == true)
        {
            Door1.transform.Translate(Vector3.up * Time.deltaTime * 8);
            if (Door1.transform.position.y > 3.4f)
            {
                doorIsOpening = false;
            }
        }
       
        if(Door1.transform.position.y >3.45f)
        {
            Door1.transform.Translate(Vector3.down * Time.deltaTime * 8);
            if (Door1.transform.position.y < 1.6f)
            {
                doorIsOpening = false;
            }
        }
    }
    void OnMouseDown()
    {
        doorIsOpening = true;
    }

}
