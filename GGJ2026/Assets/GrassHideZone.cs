using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassHideZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var stealth = other.GetComponent<PlayerStealth>();
            if (stealth != null) stealth.hiddenInGrass = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var stealth = other.GetComponent<PlayerStealth>();
            if (stealth != null) stealth.hiddenInGrass = false;
        }
    }
}
