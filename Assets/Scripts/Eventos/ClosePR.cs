using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePR : MonoBehaviour
{
    public GameObject open;
    public PuertaRota door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            door.ChangeDoorState();

            open.SetActive(false);
        }
    }
}
