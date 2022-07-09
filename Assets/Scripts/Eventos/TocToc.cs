using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocToc : MonoBehaviour
{
    public AudioClip toc;
    public bool playclip;

    

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(toc, transform.position, 10);
        }
    }

    

    
}
