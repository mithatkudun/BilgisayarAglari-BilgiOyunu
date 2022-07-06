using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovements : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 15;
    private Vector3 move;
    InputAction movement;
    public FixedJoystick joystick;
    public FixedTouchField TouchField;
    public MouseLook MouseLook;

    void Start()
    {
        movement = new InputAction("PlayerMovement", binding: "<Gamepad>/leftStick");
        movement.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float x = joystick.Horizontal;
        float z = joystick.Vertical;

        move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        MouseLook.LookAxis = TouchField.TouchDist;
    }
}
