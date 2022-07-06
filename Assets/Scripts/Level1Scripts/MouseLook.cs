using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensivitity = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    [HideInInspector]
    public Vector2 LookAxis;
    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = LookAxis.x * mouseSensivitity * Time.deltaTime;
        float mouseY = LookAxis.y * mouseSensivitity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
