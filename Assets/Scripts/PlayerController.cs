using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;
    public float horizontalSpeed = 3f;
    public float verticalSpeed = 3f;
    public float MovementSpeed = 5;
    public float Gravity = 9.8f;
    private float velocity = 0;
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;

        Cursor.visible = false;

        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // player movement - forward, backward, left, right
        float horizontal = Input.GetAxis("Horizontal") * MovementSpeed;
        float vertical = Input.GetAxis("Vertical") * MovementSpeed;
        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        characterController.Move((Vector3.right * horizontal + Vector3.forward * vertical) * Time.deltaTime);
        
        cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);

        characterController.transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0.0f);

        // Gravity
        if (characterController.isGrounded)
        {
            velocity = 0;
        }
        else
        {
            velocity -= Gravity * Time.deltaTime;
            characterController.Move(new Vector3(0, velocity, 0));
        }
    }
}
