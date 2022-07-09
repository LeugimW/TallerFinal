using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reitentar : MonoBehaviour
{
    public GameObject menu;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Sotano");
        }
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;

        menu.SetActive(false);

        StartCoroutine("Esperar");
    }
    public void BotonStart()
    {
        SceneManager.LoadScene("Sotano");
    }

    public void BotonQuit()
    {
        Debug.Log("Salir");
        Application.Quit();
    }

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(6);
        menu.SetActive(true);
    }
}
