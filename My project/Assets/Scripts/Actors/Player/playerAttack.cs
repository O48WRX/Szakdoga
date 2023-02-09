using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameBaseClassLibrary.Actor.Abstracts;
using ActorClassLibrary.Abstracts;
using Unity.VisualScripting;
using StateLibrary.ActorState;
using StateLibrary.ActorState.PlayerState;

public class playerAttack : PlayerAttackAbstract
{
    private float attackCooldown = 0.6f;
    private Animator anim;
    private PlayerMovementBehaviour playerMovement;
    private float cooldownTimer = Mathf.Infinity;
    private bool dead = false;
    private ActorState state;
    private float pickupTimerDelta = 0.0f;
    private float pickupTimerSeconds = 0.0f;

    internal int maxHealth = 100;

    public bool IsPlayerDead()
    {
        bool isDead = dead;
        return isDead;
    }

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
            enemy.GetComponent<Enemy>().TakeDamage(System.Convert.ToInt32(playerAttackDamage * state.getDamageGiven()));
        }
    }

    public void Start()
    {
        currentHealth = maxHealth;
    }

    public void setState(ActorState state)
    {
        this.state = state;
    }

    public void Awake()
    {
        anim = GetComponent<Animator>();
        state = new PlayerDefaultState();
        playerMovement = GetComponent<PlayerMovementBehaviour>();
    }

    public void pickupTimer() 
    {
        if (state is not PlayerDefaultState && state != null)
        {
            pickupTimerDelta += Time.deltaTime;
            pickupTimerSeconds = pickupTimerDelta % 60;
        }

        if (pickupTimerSeconds >= 10.0f)
        {
            setState(new PlayerDefaultState());
        }
    }

    public void Update()
    {
        pickupTimer();

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

        if ((currentHealth - (damage * state.getDamageTaken())) <= 0)
        {
            dead = true;
            Die();
            return;
        }
        currentHealth -= damage;
        anim.SetTrigger("isHurt");
    }
}
