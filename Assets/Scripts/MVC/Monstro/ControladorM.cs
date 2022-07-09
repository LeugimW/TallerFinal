using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControladorM : MonoBehaviour
{
    public ModeloM modelm;

    void Start()
    {
        modelm.player = GameObject.Find("PlayerFinal").transform;
        modelm.agent = GetComponent<NavMeshAgent>();
        modelm.anim = GetComponent<Animator>();
    }

    void Update()
    {

        if (modelm.walkPointSet == true)
        {
            modelm.timermov -= Time.deltaTime;
            if (modelm.timermov <= 0)
            {
                modelm.walkPointSet = false;
                modelm.timermov = 10;
            }

        }

        modelm.anim.SetFloat("VelX", modelm.x);
        modelm.anim.SetFloat("VelY", modelm.y);

        /*if (GameObject.FindGameObjectWithTag("Taquilla").GetComponent<Esconderse>().entra == true)
        {
            modelm.playerInSightRange = false;
        }
        if (GameObject.FindGameObjectWithTag("Pasillos").GetComponent<NoPasar>().noChase == true)
        {
            modelm.playerInSightRange = false;
            //Debug.Log("No Arreglado pa");
        }*/

        modelm.playerInSightRange = Physics.CheckSphere(transform.position, modelm.sightRange, modelm.whatIsPlayer);

        if (!modelm.playerInSightRange) Patroling();
        if (modelm.playerInSightRange) ChasePlayer();

        theme();
    }

    private void Patroling()
    {
        modelm.sightRange = 20;

        if (!modelm.walkPointSet) SearchWalkPoint();

        if (modelm.walkPointSet)
            modelm.agent.SetDestination(modelm.walkPoint);

        Vector3 distanceToWalkPoint = transform.position - modelm.walkPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
        {
            modelm.walkPointSet = false;
            modelm.timermov = 10;
        }

    }

    private void SearchWalkPoint()
    {
        //Calculate random point in range
        float randomZ = Random.Range(-modelm.walkPointRange, modelm.walkPointRange);
        float randomX = Random.Range(-modelm.walkPointRange, modelm.walkPointRange);

        modelm.walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(modelm.walkPoint, -transform.up, 2f, modelm.whatIsGround))
        {
            modelm.walkPointSet = true;

        }
    }

    private void ChasePlayer()
    {
        modelm.sightRange = 30;
        modelm.agent.SetDestination(modelm.player.position);
    }

    void theme()
    {
        if (modelm.playerInSightRange)
        {
            modelm.ChaseTheme.PlayOneShot(modelm.musica_tension, 0.7F);
        }
    }
}
