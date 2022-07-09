using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ModeloM : MonoBehaviour
{
    public NavMeshAgent agent;

    public float timermov = 7;

    public AudioSource ChaseTheme;
    public AudioClip musica_tension;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    public Vector3 walkPoint;
    public bool walkPointSet;
    public float walkPointRange;

    public float sightRange;
    public bool playerInSightRange;

    public float x, y;
    public Animator anim;
}
