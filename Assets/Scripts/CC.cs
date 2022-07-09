using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CC : MonoBehaviour
{
    Transform myCamera;

    CharacterController controller;

    //movement

    public float walkSpeed = 3f;

    public float runSpeed = 5f;

    float runMultiplier = 1f;

    [Header("Rotation Settings")]

    public float lookSpeed = 5f;

    public float lookLimit = 40f;

    [Header("Extra Settings")]

    public float airControl = 0.7f;

    Vector3 lastDirection;

    [Header("Animator Settings")]
    public Animator _animator;

    public bool crouch;

    public float timer = 0.1f;


    //jump

    Vector3 velocity;
    public float gravity = -1.8f;

    public float jumpHeigth = 2f;

    bool isGrounded;

    float xCameraRotation = 0;



    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        controller = GetComponent<CharacterController>();
        myCamera = Camera.main.transform;
    }


    private void Update()
    {

        GroundedCheck();
        RunCheck();
        Movement();
        Rotation();
        JumpCheck();

        Crouch();

        if (crouch == true)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            crouch = false;
        }

    }


    void GroundedCheck()
    {
        isGrounded = controller.isGrounded;

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

    }


    void JumpCheck()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeigth * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

    }

    void Movement()
    {
        //MOVEMENT

        Vector3 forward = transform.forward;
        Vector3 right = transform.right;

        float xSpeed = Input.GetAxis("Vertical") * walkSpeed * runMultiplier;
        float ySpeed = Input.GetAxis("Horizontal") * walkSpeed * runMultiplier;

        Vector3 moveDirection = (forward * xSpeed) + (right * ySpeed);

        //if grouded, update last direction, if on air, then move toward momentum and move according to air
        if (isGrounded)
        {
            lastDirection = moveDirection;
        }
        else
        {
            moveDirection = lastDirection + ((lastDirection - moveDirection) * -airControl);
            
        }

        //apply movement
        controller.Move(moveDirection * Time.deltaTime);

    }

    void Rotation()
    {
        //ROTATION
        //rotation on x

        xCameraRotation += -Input.GetAxis("Mouse Y") * lookSpeed * Time.deltaTime;
        xCameraRotation = Mathf.Clamp(xCameraRotation, -lookLimit, lookLimit);

        Quaternion cameraRotation = Quaternion.Euler(xCameraRotation, 0, 0);

        myCamera.localRotation = cameraRotation;

        //rotation on y

        transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed * Time.deltaTime, 0);

    }

    void RunCheck()
    { 
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            runMultiplier = runSpeed;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            runMultiplier = 1f;

        }

    }

    void Crouch()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            timer = 0.1f;
            crouch = true;


            if (crouch == true)
            {
                _animator.SetBool("Crouch", true);
            }
        }
        if (crouch == false)
        {
            _animator.SetBool("Crouch", false);
        }
    }
}
