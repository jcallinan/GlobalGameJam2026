using UnityEngine;

public class EnemyRanged : EnemyBase
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float attackRange = 10f;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > attackRange)
        {
            agent.SetDestination(player.position);
        }
        else
        {
            agent.ResetPath();

            transform.LookAt(new Vector3(
                player.position.x,
                transform.position.y,
                player.position.z
            ));

            if (CanAttack())
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
         Vector3 dir = (player.position - firePoint.position).normalized;
    Quaternion rot = Quaternion.LookRotation(dir);

    Instantiate(projectilePrefab, firePoint.position, rot);
    ResetAttackTimer();
        ///Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        ///ResetAttackTimer();
    }
}
