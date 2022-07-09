using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public void BotonStart()
    {
        SceneManager.LoadScene("Menu Principal");
    }

    public void BotonQuit()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}
