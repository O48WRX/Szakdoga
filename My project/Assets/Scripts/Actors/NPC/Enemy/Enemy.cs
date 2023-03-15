using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameBaseClassLibrary.Actor.Abstracts;

public class Enemy : EnemyAbstract
{
    [SerializeField]
    HealthBar NPCHealthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        NPCHealthBar.SetMaxHealth(maxHealth);
    }

    public override void Die()
    {
        Debug.Log("Enemy died!");
        anim.SetBool("IsDead", true);

        this.enabled = false;
        GetComponent<Enemy>().enabled = false;

    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        NPCHealthBar.HealthSet(currentHealth);
    }
}
