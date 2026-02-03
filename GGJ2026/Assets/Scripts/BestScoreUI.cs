using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScoreUI : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;

    void Start()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        bestScoreText.text = "BEST SCORE: " + bestScore;
    }
}