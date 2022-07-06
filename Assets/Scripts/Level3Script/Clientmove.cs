using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clientmove : MonoBehaviour
{
    
    Touch touch;
    public float power = 5f;
    public float maxDrag = 5f;
    public LineRenderer lr;
    public Rigidbody2D rb;
    Vector3 dragStartPos;

    private void Start()
    {    
        Time.timeScale = 1f;
    }

    public void Update()
    {    
            BallPower();           
    }
    void DragStart()
    {
        dragStartPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y+5f, 15f));
        dragStartPos.z = 0.51f;
        
        lr.positionCount = 1;
        lr.SetPosition(0, dragStartPos);
    }
    void Dragging()
    {
        Vector3 draggingPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y+5f, 15f));
        draggingPos.z = 0.51f;
        lr.positionCount = 2;
        lr.SetPosition(1, draggingPos);

    }
    void DragRelease()
    {
        lr.positionCount = 0;
        Vector3 dragReleasePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y+5f, 15f));
        dragReleasePos.z = 0.51f;

        Vector3 force = dragStartPos - dragReleasePos;
        Vector3 clampedForce = Vector3.ClampMagnitude(force, maxDrag) * power;
        rb.AddForce(clampedForce, ForceMode2D.Impulse);

    }
    void BallPower()
    {

        if (Input.GetMouseButtonDown(0))
        {
            DragStart();
        }
        if (Input.GetMouseButton(0))
        {
            Dragging();
        }
        if (Input.GetMouseButtonUp(0))
        {
            DragRelease();
        }
    }

}

