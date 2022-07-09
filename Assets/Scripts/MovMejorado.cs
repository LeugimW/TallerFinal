using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovMejorado : MonoBehaviour
{
    public NavMeshAgent agent;

    public float timermov = 7;

    public AudioSource ChaseTheme;
    public AudioClip musica_tension;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    public float sightRange;
    public bool playerInSightRange;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerFinal").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(walkPointSet == true)
        {
            timermov -= Time.deltaTime;
            if(timermov <= 0)
            {
                walkPointSet = false;
                timermov = 10;
            }

        }
        
        if(GameObject.FindGameObjectWithTag("Taquilla").GetComponent<Esconderse>().entra == true)
        {
            playerInSightRange = false;
        }
        if(GameObject.FindGameObjectWithTag("Pasillos").GetComponent<NoPasar>().noChase == true)
        {
            playerInSightRange = false;
            //Debug.Log("No Arreglado pa");
        }
        
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

        if (!playerInSightRange) Patroling();
        if (playerInSightRange) ChasePlayer();

        theme();
    }

    private void Patroling()
    {
        sightRange = 20;

        if (!walkPointSet) SearchWalkPoint();

        if (walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
            timermov = 10;
        }
            
    }

    private void SearchWalkPoint()
    {
        //Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
        {
            walkPointSet = true;
           
        }
    }

    private void ChasePlayer()
    {
        sightRange = 30;
        agent.SetDestination(player.position);
    }

    void theme()
    {
        if (playerInSightRange)
        {
            ChaseTheme.PlayOneShot(musica_tension, 0.7F);
        }
    }
}
