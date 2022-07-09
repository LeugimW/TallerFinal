using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveRombo : MonoBehaviour
{
    public bool Obtenida = false;

    public void Update()
    {
        Destroy();
    }

    public void Destroy()
    {
        if (Obtenida == true)
        {
            Destroy(gameObject);
        }
    }
}
