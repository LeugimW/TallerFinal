using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Muerte : MonoBehaviour
{
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene("Screamer");
            //_animator.SetBool("Efecto", true);
        }
    }

    /*IEnumerator Esperar()
    {
        yield return new WaitForSeconds(6);
        menu.SetActive(true);
    }*/

}
