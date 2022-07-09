using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaFusibless : MonoBehaviour
{
    public  Fusible1 on1;
    public  Fusible2 on2;
    public  Fusible3 on3;

    [SerializeField]
    GameObject focos;
    public GameObject fusibleS;
    [SerializeField]
    public bool Final;
    [SerializeField]
    GameObject FinalDoor;
    [SerializeField]
    public bool A;
    public bool B;
    public bool C;
    [SerializeField]
    public bool palanca;
    [SerializeField]
    public bool colocar;
    [SerializeField]
    public bool luces;
    [SerializeField]
    public LlaveCarro Auto;




    void Update()
    {
        Fusible();

        if (A == true && B == true && C == true)
        {
            palanca = true;
        }

        colocarF();

        if(colocar == true)
        {
            luces = true;
        }

        Sistemaluces();

        if(luces == true && Auto.Obtenida == true)
        {
            Final = true;
        }

        FinalStage();
    }
    void Fusible()
    {
        if (on1.ffusible1 == true)
        {
            A = true;
        }
        if (on2.ffusible2 == true)
        {
            B = true;
        }
        if (on3.ffusible3 == true)
        {
            C = true;
        }
    }

    void colocarF()
    {
        if(colocar == true)
        {
            fusibleS.SetActive(true);
            Debug.Log("l");
        }
        
    }
    void Sistemaluces()
    {
        if(luces == true)
        {
            focos.SetActive(true);
            Debug.Log("a");
        }
    }

    void FinalStage()
    {
        if(Final == true)
        {
            FinalDoor.SetActive(true);
            Debug.Log("s");
        }
    }
}
