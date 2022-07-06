
using UnityEngine;
public class MouseControl : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 targetPos;
    public bool isMoving;
    void Start()
    {
        targetPos = transform.position;
        isMoving = false;
    }


    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            SetTarggetPosition();

        }
        else
        {
            isMoving = false;
            targetPos = new Vector3(0, 0, 0);
        }
        if (isMoving)
        {
            MoveObject();
        }
        if (Input.GetMouseButtonDown(0))
        {
            isMoving = false;
        }
    }
    void SetTarggetPosition()
    {
        Plane plane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float point = 0f;

        if (plane.Raycast(ray, out point))
            targetPos = ray.GetPoint(point);

        isMoving = true;
    }
    void MoveObject()
    {
        transform.LookAt(targetPos);
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (transform.position == targetPos)
            isMoving = false;
        Debug.DrawLine(transform.position, targetPos, Color.red);

    }
}