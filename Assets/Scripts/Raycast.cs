using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private int rango = 4;

    public GameObject Cam;

    public SistemaFusibless on;

    //public LlaveCeleste onC;

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Cam.transform.position, Camera.main.transform.forward, out hit, rango))
        {
            if(hit.collider.GetComponent<Esconderse>() == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.GetComponent<Esconderse>().entra = true;
                }
            }

            if(hit.collider.tag == "Door")
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Puerta>().ChangeDoorState();
                }
            }
            if (hit.collider.tag == "LlaveC")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<LlaveCeleste>().Obtenida = true;
                }
            }
            if (hit.collider.tag == "PCeleste")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<PCeleste>().ChangeDoorState();
                }
            }
            if (hit.collider.tag == "LlaveP")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<LlavePurpura>().Obtenida = true;
                }
            }
            if (hit.collider.tag == "PPurpura")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<PPurpura>().ChangeDoorState();
                }
            }
            if (hit.collider.tag == "Ganzua")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<LlaveGanzua>().Obtenida = true;
                }
            }
            if (hit.collider.tag == "PGanzua")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<PGanzua>().ChangeDoorState();
                }
            }
            if (hit.collider.tag == "LlaveR")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<LlaveRombo>().Obtenida = true;
                }
            }
            if (hit.collider.tag == "PRombo")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<PRombo>().ChangeDoorState();
                }
            }
            if (hit.collider.tag == "LlaveCarro")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<LlaveCarro>().Obtenida = true;
                }
            }
            if (hit.collider.tag == "Fusible1")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Fusible1>().ffusible1 = true;
                }
            }
            if (hit.collider.tag == "Fusible2")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Fusible2>().ffusible2 = true;
                }
            }
            if (hit.collider.tag == "Fusible3")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Fusible3>().ffusible3 = true;
                }
            }

            if (hit.collider.GetComponent<SistemaFusibless>() == true)
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    if(on.palanca == true)
                    {
                        on.colocar = true;
                    }

                }
                
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * rango);
    }
}



