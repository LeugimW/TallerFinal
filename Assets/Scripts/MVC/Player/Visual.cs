using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visual : MonoBehaviour
{
    public ModeloP model;
    private void Update()
    {

        Rotation();
        Crouch();

        if (model.crouch == true)
        {
            model.timer -= Time.deltaTime;
        }
        if (model.timer <= 0)
        {
            model.crouch = false;
        }

    }


    void Rotation()
    {
        //ROTATION
        //rotation on x

        model.xCameraRotation += -Input.GetAxis("Mouse Y") * model.lookSpeed * Time.deltaTime;
        model.xCameraRotation = Mathf.Clamp(model.xCameraRotation, -model.lookLimit, model.lookLimit);

        Quaternion cameraRotation = Quaternion.Euler(model.xCameraRotation, 0, 0);

        model.myCamera.localRotation = cameraRotation;

        //rotation on y

        transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * model.lookSpeed * Time.deltaTime, 0);

    }

    void Crouch()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            model.timer = 0.1f;
            model.crouch = true;


            if (model.crouch == true)
            {
                model._animator.SetBool("Crouch", true);
            }
        }
        if (model.crouch == false)
        {
            model._animator.SetBool("Crouch", false);
        }
    }
}
