using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Animator )) ]
public class CharacterAnimation : MonoBehaviour
{
   
    Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    public void MoveAnimation(float horizontal)
    {
        
        _animator.SetFloat("moveSpeed", Mathf.Abs(horizontal));   //mathf unitynin matemeatik kütüphanesidir Abs ile mutlak değere atadık ki geri geride eksi değer olmasın 
        
    }
    public void JumpAnimation(bool isJump)  //true ise zıplıcak
    {
        _animator.SetBool("isJump", isJump);
    }
    public void RunAnimation(bool isRun) 
    { 

        _animator.SetBool("isRun", isRun);
    }

    
}
