using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Animator _animator;
    private bool FlashState;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
            if (FlashState == false)
            {
                _animator.SetBool("Flashlight", true);
                FlashState = true;
            }
            else if(FlashState == true)
            {
                _animator.SetBool("Flashlight", false);
                FlashState = false;
            }
        }
    }
}
