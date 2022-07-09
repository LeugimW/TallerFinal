using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorP : MonoBehaviour
{
    public ModeloP model;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        model.controller = GetComponent<CharacterController>();
        model.myCamera = Camera.main.transform;
    }


    private void Update()
    {
        GroundedCheck();
        RunCheck();
        Movement();
        JumpCheck();
    }

    void Movement()
    {
        //MOVEMENT

        Vector3 forward = transform.forward;
        Vector3 right = transform.right;

        float xSpeed = Input.GetAxis("Vertical") * model.walkSpeed * model.runMultiplier;
        float ySpeed = Input.GetAxis("Horizontal") * model.walkSpeed * model.runMultiplier;

        Vector3 moveDirection = (forward * xSpeed) + (right * ySpeed);



        //apply movement
        model.controller.Move(moveDirection * Time.deltaTime);

    }

    void GroundedCheck()
    {
        model.isGrounded = model.controller.isGrounded;

        if (model.isGrounded && model.velocity.y < 0)
        {
            model.velocity.y = -2f;
        }

    }

    void JumpCheck()
    {
        if (Input.GetButtonDown("Jump") && model.isGrounded)
        {
            model.velocity.y = Mathf.Sqrt(model.jumpHeigth * -2f * model.gravity);
        }

        model.velocity.y += model.gravity * Time.deltaTime;
        model.controller.Move(model.velocity * Time.deltaTime);

    }
    void RunCheck()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            model.runMultiplier = model.runSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            model.runMultiplier = 1f;

        }

    }


}
