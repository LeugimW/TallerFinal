using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform door;

    public bool isUnlocked = true;

    public float doorSpeed = 1f;

    public Transform openTransform;

    public Transform closedTransform;

    Vector3 targetPosition;

    float time;

    void Start()
    {
        targetPosition = closedTransform.position;        
    }

   
    void Update()
    {
        if (isUnlocked && door.position != targetPosition)
        {
            door.transform.position = Vector3.Lerp(door.transform.position, targetPosition, time);
            time += Time.deltaTime * doorSpeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            targetPosition  = openTransform.position;
            time = 0;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            targetPosition = closedTransform.position;
            time = 0;
        }
    }
}
