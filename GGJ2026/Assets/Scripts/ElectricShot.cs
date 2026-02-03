using System.Collections;
using UnityEngine;

public class ElectricShot : Ability
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    /// <summary>
    /// public Camera cam;
    /// </summary>
    Animator animator;

    public void Start()
    {
        animator = GetComponent<Animator>();

        ///if (cam == null)
            ///cam = GetComponent<Camera>().main;
    }

    public override void Activate()
    {
        var stealth = GameObject.FindGameObjectWithTag("Player")
    .GetComponent<PlayerStealth>();

        if (stealth != null)
            stealth.RevealTemporarily();






        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
       animator.SetBool("IsAttacking", true);
        StartCoroutine(WaitForSeconds());
        ///Vector3 direction = cam.transform.forward;
    ///Quaternion rotation = Quaternion.LookRotation(direction);

   /// Instantiate(projectilePrefab, firePoint.position, rotation);

    ///animator.SetBool("IsAttacking", true);
    ///StartCoroutine(WaitForSeconds());

    }
    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(.1f);

        animator.SetBool("IsAttacking", false);
    }

}
