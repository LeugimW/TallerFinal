using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBreak : MonoBehaviour
{
    public AudioClip breakDoor;
    public GameObject doorBlock;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(breakDoor, transform.position, 0.1f);
            doorBlock.SetActive(false);
        }
    }
}
