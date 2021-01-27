using Assets.GameFolders.Scripts.Abstracts.Inputs;
using Assets.GameFolders.Scripts.Concretes.Movers;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using Unity.Collections;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerController : MonoBehaviour
{

    
    float horizontal;
    bool isjump=true;
    bool isrun;
    
    IPlayerInput _input;
    Mover _mover;
    Jump _Jump;
    CharacterAnimation _animator;
    Flip _flip;
    Health _health;
    
    private void Awake()
    {
        _animator = GetComponent<CharacterAnimation>();
        _Jump = GetComponent<Jump>();
        _mover = GetComponent<Mover>();
        _input = new Pcinput();  //ınstancenı örneğini alır
        _flip = GetComponent<Flip>();
        _health = GetComponent<Health>();
    }
    private void Update()
    {
        horizontal = _input.Horizontal;
        

        if (_input.isrun)
        {
            
            isrun = true;
        }

        if (  _input.isJumpButton)
        {
            
            isjump = true;

            
        }

      
        
    }
    
    void FixedUpdate()
    {
        _animator.MoveAnimation(horizontal);
        
        
        _mover.MoveAction(horizontal);
        _flip.FlipCharacter(horizontal );

        if (isrun)
        {
            _mover.MoveAction(horizontal);
            
            isrun = false;
            
        }
        //_animator.RunAnimation(_mover.Run);
        if (isjump)
        {
            _Jump.JumpAction();
            
            isjump = false;
            
        }
        _animator.JumpAnimation(_Jump.IsJumpAction);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Damage damage = collision.collider.GetComponent<Damage>();
        if (damage!=null)
        {

            _health.TakeHit(damage);
            return;
        }
    }
}
