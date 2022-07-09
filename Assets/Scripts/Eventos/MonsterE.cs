using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterE : MonoBehaviour
{
    public Notas act;
    private Animation anim;

    public Animator _animator;
    bool isPlayin = false;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        _animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (act.activa == true && !isPlayin)
        {
            frenesi();
        }

    }

    void frenesi()   
    {
        _animator.SetBool("on", true);
        isPlayin = true;
    }
}
