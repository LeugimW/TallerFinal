using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    [Header("Pause")]
    private bool pause = false;
    public GameObject panelPause;
    //public GameObject music;
    private CC playerScript;
    private Notas act;
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<CC>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            pause = !pause;
        }
        if(pause)
        {
            Time.timeScale = 0;
            playerScript.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            panelPause.SetActive(true);
            //music.SetActive(false);
        }
        else if(!pause)
        {
            Time.timeScale = 1;
            playerScript.enabled = true;
            //Cursor.lockState = CursorLockMode.Locked;
            panelPause.SetActive(false);
            //music.SetActive(true);
           
            if (act.activa == true)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else if (act.activa == false)
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    public void AplicationPause()
    {
        pause = !pause;
    }
}
