using System.Collections;
using UnityEngine;

public class ElectricShot : Ability
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    Animator animator;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    public override void Activate()
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        animator.SetBool("IsAttacking", true);
        StartCoroutine(WaitForSeconds());

    }
    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(.1f);

        animator.SetBool("IsAttacking", false);
    }

}
