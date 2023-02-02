using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameBaseClassLibrary.Actor.Abstracts;
using ActorClassLibrary.Abstracts;
using Unity.VisualScripting;

public class playerAttack : PlayerAttackAbstract
{
    private float attackCooldown = 0.6f;
    private Animator anim;
    private PlayerMovementBehaviour playerMovement;
    private float cooldownTimer = Mathf.Infinity;
    private bool dead = false;

    internal int maxHealth = 100;

    public override void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        // Detect enemies in range of attack
        // Then damage each one of them.

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit: " + enemy.name);
            enemy.GetComponent<Enemy>().TakeDamage(playerAttackDamage);
        }
    }

    public void Start()
    {
        currentHealth = maxHealth;
    }

    public void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovementBehaviour>();
    }

    public void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.Space) && cooldownTimer > attackCooldown && playerMovement.canAttack())
            Attack();
        cooldownTimer += Time.deltaTime;
    }

    public override void Die()
    {
        Debug.Log("Player died!");
        anim.SetBool("isDead", true);

        this.enabled = false;
        GetComponent<PlayerMovementBehaviour>().enabled = false;
        GetComponent<playerAttack>().enabled = false;
    }

    public override void TakeDamage(int damage)
    {
        if(dead) return;

        if ((currentHealth - damage) <= 0)
        {
            dead = true;
            Die();
            return;
        }
        currentHealth -= damage;
        anim.SetTrigger("isHurt");
    }
}
