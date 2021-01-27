using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] int damage=1;     
    public int HitDamage => damage;
    private void Start()
    {
        scoretext.scoreValue = 0;
    }


    public void HitTarget(Health health)
    {
        health.TakeHit(this);
    }
}
