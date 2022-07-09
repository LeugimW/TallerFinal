using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer : MonoBehaviour
{
    public AudioClip Scream;
    void Start()
    {
        AudioSource.PlayClipAtPoint(Scream, transform.position, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
