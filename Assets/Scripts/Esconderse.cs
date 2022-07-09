using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esconderse : MonoBehaviour
{
    [SerializeField]
    private Transform dentro, fuera;
    [SerializeField]
    private float tiempo;

    private GameObject Player;
    public bool entra;
    private bool sale;

    Transform playerT;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerT = Player.GetComponent<Transform>();
    }

    void Update()
    {
        if(entra == true)
        {
            playerT.position = Vector3.Lerp(playerT.position, dentro.position, tiempo * Time.deltaTime);
            playerT.rotation = Quaternion.Lerp(playerT.rotation, dentro.rotation, tiempo * Time.deltaTime);
            Player.GetComponentInChildren<CharacterController>().enabled = false;

            if(Input.GetKeyDown(KeyCode.Escape))
            {
                entra = false;
                sale = true;
            }
        }

        if(sale == true)
        {
            playerT.position = Vector3.Lerp(playerT.position, fuera.position, tiempo * Time.deltaTime);
            playerT.rotation = Quaternion.Lerp(playerT.rotation, fuera.rotation, tiempo * Time.deltaTime);
            StartCoroutine(finEscondite());
        }
    }

    IEnumerator finEscondite()
    {
        yield return new WaitForSeconds(2);
        sale = false;
        Player.GetComponentInChildren<CharacterController>().enabled = true;
    }
}
