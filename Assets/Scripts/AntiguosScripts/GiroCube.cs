using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroCube : MonoBehaviour
{
    public float speedH;
    public float speedV;
    public GameObject cubo;

    float movH;
    float movV;


    void Update()
    {

    }

    private void OnMouseDrag()
    {
        movH -= speedH * Input.GetAxis("Mouse X");
        movV += speedV * Input.GetAxis("Mouse Y");

        if (Input.GetMouseButton(0))
        {
            cubo.transform.Rotate(movH, movV, 0);  
        }
    }
}

