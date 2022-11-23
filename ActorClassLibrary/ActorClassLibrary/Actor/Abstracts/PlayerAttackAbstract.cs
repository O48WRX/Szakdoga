using ActorClassLibrary.Interfaces;
using GameBaseClassLibrary.Actor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ActorClassLibrary.Abstracts
{
    public abstract class PlayerAttackAbstract : MonoBehaviour, PlayerAttackInterface, Mortal
    {
        public Transform AttackPoint;
        public float attackRange = 0.5f;

        public LayerMask enemyLayers;

        public int playerAttackDamage = 50;


        public int currentHealth;


        public abstract void Attack();

        public void OnDrawGizmosSelected()
        {
            if (AttackPoint == null)
                return;
            Gizmos.DrawWireSphere(AttackPoint.position, attackRange);
        }

        public abstract void TakeDamage(int damage);
        public abstract void Die();
    }
}
