using UnityEngine;

public class AbilityController : MonoBehaviour
{
    public Ability[] abilities;
    private int currentAbility;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) currentAbility = 0;
        if (Input.GetKeyDown(KeyCode.Alpha2)) currentAbility = 1;
        if (Input.GetKeyDown(KeyCode.Alpha3)) currentAbility = 2;

        if (Input.GetMouseButtonDown(0))
        {
            if (abilities.Length > 0)
                abilities[currentAbility].Activate();
        }
    }
}
