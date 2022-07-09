using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fusible3 : MonoBehaviour
{
    public bool ffusible3 = false;
    public void Update()
    {
        Destroy();
    }

    public void Destroy()
    {
        if (ffusible3 == true)
        {
            Destroy(gameObject);
        }
    }
}
