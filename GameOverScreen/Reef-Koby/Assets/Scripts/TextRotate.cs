using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomTextSwitcher : MonoBehaviour
{
    public TMP_Text[] texts;           // assign your 3 TMP objects here
    public float changeEvery = 3f;
    public bool randomOrder = true;
    public bool avoidImmediateRepeat = true;
    public bool useUnscaledTime = false;

    private int currentIndex = -1;
    private float timer = 0f;

    void Start()
    {
        // disable all then show one immediately
        if (texts == null || texts.Length == 0) return;
        for (int i = 0; i < texts.Length; i++) texts[i].gameObject.SetActive(false);
        ShowNext();
    }

    void Update()
    {
        float dt = useUnscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
        timer += dt;
        if (timer >= changeEvery)
        {
            timer = 0f;
            ShowNext();
        }
    }

    void ShowNext()
    {
        if (texts.Length == 0) return;

        int next = 0;
        if (randomOrder)
        {
            next = Random.Range(0, texts.Length);
            if (avoidImmediateRepeat && texts.Length > 1)
            {
                while (next == currentIndex)
                    next = Random.Range(0, texts.Length);
            }
        }
        else
        {
            next = (currentIndex + 1) % texts.Length;
        }

        // turn off old, enable new
        for (int i = 0; i < texts.Length; i++)
            texts[i].gameObject.SetActive(i == next);

        currentIndex = next;
    }
}