using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyBase : MonoBehaviour
{
    public float health = 500f;
    public float damage = 10f;
    public float attackCooldown = 1.5f;

    protected Transform player;
    protected NavMeshAgent agent;
    protected float lastAttackTime;

    protected virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    public virtual void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
        GameManager.Instance.AddScore(10);
    }

    protected bool CanAttack()
    {
        return Time.time >= lastAttackTime + attackCooldown;
    }

    protected void ResetAttackTimer()
    {
        lastAttackTime = Time.time;
    }
}

