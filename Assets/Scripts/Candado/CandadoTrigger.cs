using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandadoTrigger : MonoBehaviour
{
    //public GameObject trigger;
    public GameObject colliderDoor1;
    public GameObject colliderDoor2;
    public GameObject colliderDoor3;
    public GameObject candado;
    public GameObject trigger;
    public Notas cam;
    public Notas not;

    public int a = 0;
    public int b = 0;
    public int c = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Candado1"))
        {
            Debug.Log("hola");
            colliderDoor1.SetActive(false);
            a = 1;
}
        if (other.tag == "Candado2")
        {
            colliderDoor2.SetActive(false);
            b = 1;
        }
        if (other.tag == "Candado3")
        {
            colliderDoor3.SetActive(false);
            c = 1;
        }
        if(a == 1 && b == 1 && c ==1)
        {
            not.notaVisual.SetActive(false);
            cam.camaraVisual.SetActive(false);
            Destroy(candado);
            trigger.SetActive(false);
        }
        Debug.Log("hola");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Candado")
        {
            colliderDoor1.SetActive(true);
        }
        if (other.tag == "Candado2")
        {
            colliderDoor2.SetActive(true);
        }
        if (other.tag == "Candado3")
        {
            colliderDoor3.SetActive(true);
        }
    }

}
