using UnityEngine;

public class EnemyMelee : EnemyBase
{
    public float attackRange = 2f;

    PlayerStealth playerStealth;

    void Update()
    {
        if (playerStealth == null && player != null)
            playerStealth = player.GetComponent<PlayerStealth>();

        if (playerStealth != null && playerStealth.hiddenInGrass)
        {
            agent.ResetPath();
            return;
        }


        agent.SetDestination(player.position);

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= attackRange && CanAttack())
        {
            Attack();
        }
    }

    void Attack()
    {
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
        }

        ResetAttackTimer();
    }
}
