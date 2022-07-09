using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPasar : MonoBehaviour
{

    public bool noChase;
    
    
    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            noChase = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            noChase = false;
        }
    }

}
