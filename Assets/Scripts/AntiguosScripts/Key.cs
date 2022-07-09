using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Door doorToOpen;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            doorToOpen.isUnlocked = true;
        }

        Destroy(gameObject);
    }
}
