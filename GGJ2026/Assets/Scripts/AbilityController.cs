using UnityEngine;
using UnityEngine.UI;

public class AbilityController : MonoBehaviour
{
    public Ability[] abilities;
    private int currentAbility;

    public Image select1;
    public Image select2;
    public Image select3;

    public Sprite squidMask;
    public Sprite eelMask;
    public Sprite shrimpMask;

    private void Start()
    {
        select1.sprite = eelMask;
        select2.sprite = shrimpMask;
        select3.sprite = squidMask;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentAbility = 0;
            //select1.rectTransform.sizeDelta = new Vector2(250, 250);
            select1.sprite = eelMask;
            select2.sprite = shrimpMask;
            select3.sprite = squidMask;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentAbility = 1;
            //select2.rectTransform.sizeDelta = new Vector2(250, 250);
            select3.sprite = eelMask;
            select1.sprite = shrimpMask;
            select2.sprite = squidMask;
        }
   
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentAbility = 2;
            //select3.rectTransform.sizeDelta = new Vector2(250, 250);
            select2.sprite = eelMask;
            select3.sprite = shrimpMask;
            select1.sprite = squidMask;
        }
  

        if (Input.GetMouseButtonDown(0))
        {
            if (abilities.Length > 0)
                abilities[currentAbility].Activate();
        }
    }
}
