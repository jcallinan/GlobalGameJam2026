using UnityEngine;

public class PunchAttack : Ability
{
    public float damage = 25f;
    public float range = 2f;
    public LayerMask hitLayers;

    public override void Activate()
    {
        RaycastHit hit;

        Vector3 origin = transform.position + Vector3.up * 1f;
        Vector3 direction = transform.forward;

        if (Physics.Raycast(origin, direction, out hit, range, hitLayers))
        {
            Health health = hit.collider.GetComponent<Health>();
            if (health != null)
            {
                health.TakeDamage(damage);
            }
        }
    }
}
