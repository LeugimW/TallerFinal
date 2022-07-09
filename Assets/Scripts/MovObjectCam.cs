using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovObjectCam : MonoBehaviour
{
    public float speedH;
    public float speedV;

    float movH;
    float movV;


    void Update()
    {

    }

    private void OnMouseDrag()
    {
        movH -= speedH * Input.GetAxis("Mouse X");
        movV += speedV * Input.GetAxis("Mouse Y");

        if(Input.GetMouseButton(0))
        {
            transform.eulerAngles = new Vector3(movV, movH, 0f);
        }
    }
}
