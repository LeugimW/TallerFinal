using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void BotonStart()
    {
        SceneManager.LoadScene("Casa");
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void BotonQuit()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}
