using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaFusibles : MonoBehaviour
{
    public int fusibles = 0;
    private bool palancaActiva;
    [SerializeField]
    private GameObject fusibleuno;
    [SerializeField]
    private GameObject fusible1Espectro;
    [SerializeField]
    private GameObject fusibleR1;
    [SerializeField]
    private GameObject fusibledos;
    [SerializeField]
    private GameObject fusible2Espectro;
    [SerializeField]
    private GameObject fusibleR2;
    [SerializeField]
    private GameObject fusibletres;
    [SerializeField]
    private GameObject fusible3Espectro;
    [SerializeField]
    private GameObject fusibleR3;

    public bool Fusible1;
    public bool Fusible2;
    public bool Fusible3;


    private void Start()
    {
        palancaActiva = false;
    }

    private void Update()
    {
        if(Fusible1 == true)
        {
            fusibles += 1;
            fusibleR1.SetActive(false);
            Debug.Log("xd");
        }
        if (Fusible2 == true)
        {
            fusibles += 1;
            fusibleR2.SetActive(false);
        }
        if (Fusible3 == true)
        {
            fusibles += 1;
            fusibleR3.SetActive(false);
        }

        if (fusibles == 3)
        {
            palancaActiva = true;
        }

        if(palancaActiva == true)
        {
            Debug.Log("Luces encendidas");
        }
    }


    public void fusible1()
    {
        if (fusibles == 1)
        {
            fusibleuno.SetActive(true);
            fusible1Espectro.SetActive(false);
        }
    }

    public void fusible2()
    {
        
        if(fusibles == 2)
        {
            fusibledos.SetActive(true);
            fusible2Espectro.SetActive(false);
        }
    }

    public void fusible3()
    {
        if (fusibles == 3)
        {
            fusibletres.SetActive(true);
            fusible3Espectro.SetActive(false);
        }
    }
}
