using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public static int CurrentScore = 0;

    // Optional: reset score at start of game
    public void ResetScore()
    {
        CurrentScore = 0;
    }

    // Call this whenever the player earns points
    public void AddScore(int amount)
    {
        CurrentScore += amount;
    }
}
