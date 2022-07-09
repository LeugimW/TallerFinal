using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeloP : MonoBehaviour
{

    public Transform myCamera;

    public CharacterController controller;

    //movement

    public float walkSpeed = 3f;

    public float runSpeed = 5f;

    public float runMultiplier = 1f;

    [Header("Rotation Settings")]

    public float lookSpeed = 5f;

    public float lookLimit = 40f;

    Vector3 lastDirection;

    [Header("Animator Settings")]
    public Animator _animator;

    public bool crouch;

    public float timer = 0.1f;

    public float xCameraRotation = 0;

    //jump

    public Vector3 velocity;

    public float gravity = -1.8f;

    public float jumpHeigth = 2f;

    public bool isGrounded;

}
