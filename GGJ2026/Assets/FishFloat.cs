using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFloatPixelPerfect : MonoBehaviour
{
    public float amplitude = 8f;
    public float frequency = 1f;
    public float pixelsPerUnit = 100f; // match your project's PPU (e.g. 100)
    public bool useUnscaledTime = false;

    RectTransform rt;
    Vector2 startPos;

    void Awake()
    {
        rt = GetComponent<RectTransform>();
        startPos = rt.anchoredPosition;
    }

    void Update()
    {
        float t = useUnscaledTime ? Time.unscaledTime : Time.time;
        float y = Mathf.Sin(t * Mathf.PI * 2f * frequency) * amplitude;
        // snap to whole pixel units
        float snappedY = Mathf.Round(y * pixelsPerUnit) / pixelsPerUnit;
        rt.anchoredPosition = startPos + new Vector2(0f, snappedY);
    }
}