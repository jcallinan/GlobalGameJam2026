using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 10f;
    public float currentHealth;
    public Score score;
    int addScore = 25;

    void Start()
    {
        currentHealth = maxHealth;
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
