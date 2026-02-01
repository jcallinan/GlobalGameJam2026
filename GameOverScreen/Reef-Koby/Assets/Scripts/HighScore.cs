using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TMP_Text scoreText; // assign in Inspector

    void OnEnable()
    {
        // Display the current score
        scoreText.text = "High Score: " + ScoreKeeper.CurrentScore;
    }
}