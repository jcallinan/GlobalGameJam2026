using UnityEngine;

public class ElectricShot : Ability
{
    public GameObject projectilePrefab;
    public Transform firePoint;

    public override void Activate()
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}
