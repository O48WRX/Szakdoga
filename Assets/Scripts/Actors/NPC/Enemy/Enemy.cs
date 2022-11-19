using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using GameBaseClassLibrary.Actor.Abstracts;

public class Enemy : EnemyAbstract
{

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public override void Die()
    {
        Debug.Log("Enemy died!");
        anim.SetBool("IsDead", true);

        this.enabled = false;
        GetComponent<Enemy>().enabled = false;

    }
}
