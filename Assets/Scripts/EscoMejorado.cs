using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscoMejorado : MonoBehaviour
{
    private bool anim = false;

    public Transform entra;
    public Transform sale;
    public float speed = 1f;
    [Range(0f, 1f)]
    public float t;

    private GameObject Player;

    Transform playerT;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerT = Player.GetComponent<Transform>();
    }

    
    void Update()
    {
        if(anim)
        {
            t += speed * Time.deltaTime;

            if (t >= 1f)
                anim = false;
            
            transform.position = Vector3.Lerp(entra.position, sale.position, t);
        }


        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim = true;
        }
    }
}
