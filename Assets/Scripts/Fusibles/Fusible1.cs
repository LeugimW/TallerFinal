using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fusible1 : MonoBehaviour
{
    public bool ffusible1 = false;
    public void Update()
    {
        Destroy();
    }

    public void Destroy()
    {
        if (ffusible1 == true)
        {
            Destroy(gameObject);
            Debug.Log("hola");
        }
    }
}
