using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDestruir : MonoBehaviour
{
    public static bool  Re;
    public LlavePurpura R;
    void Start()
    {
        if (R.Obtenida == true)
        {
            Re = true;
        }
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
