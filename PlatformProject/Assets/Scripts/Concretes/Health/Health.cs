using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int maxHealth=3;
    [SerializeField] int currentHealth = 0;

    public bool isDead => currentHealth < 1;

    private void Awake()
    {
        currentHealth = maxHealth;
    }
    public void TakeHit(Damage damage)  //zararı alacak 
    {
        if (!isDead)
        {
            GameManager.Instance.LoadScene();
        }
        
    }
}
