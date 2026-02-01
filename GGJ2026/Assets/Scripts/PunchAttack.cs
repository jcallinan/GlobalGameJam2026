using UnityEngine;
using System.Collections;


public class PunchAttack : Ability
{
    public float damage = 25f;
    public float range = 2f;
    public LayerMask hitLayers;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public override void Activate()
    {
        RaycastHit hit;

        Vector3 origin = transform.position + Vector3.up * 1f;
        Vector3 direction = transform.forward;

        if (Physics.Raycast(origin, direction, out hit, range, hitLayers))
        {
            EnemyHealth health = hit.collider.GetComponent<EnemyHealth>();
            if (health != null)
            {
                health.TakeDamage(damage);
                animator.SetBool("IsPunching", true);
                StartCoroutine(WaitForSeconds());
            }
        }
    }
    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(1f);

        animator.SetBool("IsPunching", false);
    }
}
