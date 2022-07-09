using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueoPuerta : MonoBehaviour
{
    public GameObject caja;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            caja.SetActive(false);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
