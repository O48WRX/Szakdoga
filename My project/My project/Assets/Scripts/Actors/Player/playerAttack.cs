using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    [SerializeField]private float attackCooldown = 0.6f;
    private Animator anim;
    private PlayerMovementBehaviour playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    public Transform AttackPoint;
    public float attackRange = 0.5f;

    public LayerMask enemyLayers;

    public int playerAttackDamage = 50;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovementBehaviour>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.Space) && cooldownTimer > attackCooldown && playerMovement.canAttack())
            Attack();
        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
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

    private void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
            return;
        Gizmos.DrawWireSphere(AttackPoint.position, attackRange);
    }
}
