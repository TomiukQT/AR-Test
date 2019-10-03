using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerController : MonoBehaviour
{

    Animator m_Animator;

    private void Awake()
    {
        m_Animator = GetComponent<Animator>();
    }

    private void Start()
    {
        //PlayIdle();
    }

    public void PlayIdle()
    {
        m_Animator.Play("idle");
    }

    public void PlayWalk()
    {
        m_Animator.Play("walk");
    }

    public void PlayRun()
    {
        m_Animator.Play("run");
    }

    public void PlayRoar()
    {
        m_Animator.Play("sound");
    }


}
