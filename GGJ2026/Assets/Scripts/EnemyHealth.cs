using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public Score score;
    int addScore = 25;

    void Start()
    {
        
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;

        Debug.Log("Enemy Health"+currentHealth);

        if (currentHealth <= 0)
        {
            //score.score += addScore;
            Die();

        }
    }

    void Die()
    {
        
        Destroy(gameObject);
        //SceneManager.LoadScene("GameOverScreen");
    }
}
