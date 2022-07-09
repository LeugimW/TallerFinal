using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffTocToc : MonoBehaviour
{

    public GameObject sound;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(sound);
        }
    }
}
