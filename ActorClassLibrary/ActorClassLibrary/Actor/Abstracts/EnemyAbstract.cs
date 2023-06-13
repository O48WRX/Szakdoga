using GameBaseClassLibrary.Actor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GameBaseClassLibrary.Actor.Abstracts
{
    public abstract class EnemyAbstract : MonoBehaviour, EnemyInterface
    {
        public Animator anim;

        public int maxHealth = 100;
        public int currentHealth;

        public abstract void Die();

        public virtual void TakeDamage(int damage)
        {
            if (anim.GetBool("IsDead"))
                return;

            Debug.Log("Enemy took " + damage + " damage!");
            currentHealth -= damage;

            anim.SetTrigger("Hurt");

            if (currentHealth <= 0)
            {
                Die();
            }
        }
    }
}
