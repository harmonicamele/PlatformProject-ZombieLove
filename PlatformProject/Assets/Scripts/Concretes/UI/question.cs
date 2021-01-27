using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question : MonoBehaviour
{
    public GameObject text;
    public Text score;

  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if (score.text=="100")
            {
                Destroy(this.gameObject);
            }
            if (score.text!="100")
            {
                text.SetActive(true);
                Debug.Log("asd");
               
            }
            
        }
        else
        {
            text.SetActive(false);
        }
       
    }
  


}
