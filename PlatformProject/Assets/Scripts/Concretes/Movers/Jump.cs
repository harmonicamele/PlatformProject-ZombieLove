using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]  
public class Jump : MonoBehaviour
{
    public bool IsJumpAction => rb.velocity.y != 0;  
   
   bool OnGrounded=true;
    [SerializeField] float jumpforce = 350f;
    Rigidbody2D rb;
   
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void JumpAction()
    {

        if (OnGrounded==true)
        {
            rb.AddForce(Vector2.up * jumpforce);
            OnGrounded = false;
        }
       
       
         
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("wall"))
        {
            OnGrounded = true;
        }
    }
    
} 
