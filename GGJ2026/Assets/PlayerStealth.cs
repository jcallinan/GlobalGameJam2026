using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStealth : MonoBehaviour
{
    public GameObject stealthIcon;

    public bool hiddenInGrass = false;
//
    public bool CanScore()
    {
        return !hiddenInGrass;
    }
    //

    // Optional anti-cheese: shooting reveals you briefly
    public float revealTimeAfterAttack = 1.0f;
    Coroutine revealRoutine;

    public void RevealTemporarily()
    {
        if (revealRoutine != null) StopCoroutine(revealRoutine);
        revealRoutine = StartCoroutine(RevealRoutine());
    }

    IEnumerator RevealRoutine()
    {
        bool wasHidden = hiddenInGrass;
        hiddenInGrass = false;

        yield return new WaitForSeconds(revealTimeAfterAttack);

        // Don't force re-hide unless you're actually in grass again.
        // (Grass trigger will set it back when you're inside.)
        revealRoutine = null;
    }
    void Update()
    {
        if (stealthIcon != null)
            stealthIcon.SetActive(hiddenInGrass);
    }

}
