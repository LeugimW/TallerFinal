using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fusible2 : MonoBehaviour
{
    public bool ffusible2 = false;
    public void Update()
    {
        Destroy();
    }

    public void Destroy()
    {
        if (ffusible2 == true)
        {
            Destroy(gameObject);
        }
    }
}
