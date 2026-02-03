using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 10f;
    public float currentHealth;
    public Score score;
    int addScore = 25;

    // Multi-material flash support
    Renderer[] renderers;
    Color[][] originalColors;

    void Start()
    {
        currentHealth = maxHealth;

        renderers = GetComponentsInChildren<Renderer>();
        originalColors = new Color[renderers.Length][];

        for (int i = 0; i < renderers.Length; i++)
        {
            Material[] mats = renderers[i].materials;
            originalColors[i] = new Color[mats.Length];

            for (int j = 0; j < mats.Length; j++)
            {
                originalColors[i][j] = mats[j].color;
            }
        }
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;

        StartCoroutine(FlashRed());

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    IEnumerator FlashRed()
    {
        if (renderers == null || renderers.Length == 0) yield break;

        // Flash red
        for (int i = 0; i < renderers.Length; i++)
        {
            Material[] mats = renderers[i].materials;
            for (int j = 0; j < mats.Length; j++)
            {
                mats[j].color = Color.red;
            }
        }

        yield return new WaitForSeconds(0.1f);

        // Restore original colors
        for (int i = 0; i < renderers.Length; i++)
        {
            Material[] mats = renderers[i].materials;
            for (int j = 0; j < mats.Length; j++)
            {
                mats[j].color = originalColors[i][j];
            }
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
//public class EnemyHealth : MonoBehaviour
//{
//    public float maxHealth = 10f;
//    public float currentHealth;
//    public Score score;
//    int addScore = 25;
//    /// <summary>
//    /// 
//    /// </summary>
//    Renderer Renderer;
//    Color originalColor;
//    /// <summary>
//    /// 
//    /// </summary>
//    void Start()
//    {
//        currentHealth = maxHealth;




//        enemyRenderer = GetComponentInChildren<Renderer>();
//        originalColor = enemyRenderer.material.color;
//    }

//    public void TakeDamage(float amount)
//    {
//        currentHealth -= amount;
//        ///
//        StartCoroutine(FlashRed());
//        ///
//        Debug.Log("Enemy Health" + currentHealth);

//        if (currentHealth <= 0)
//        {
//            //score.score += addScore;
//            Die();

//        }
//    }

//    void Die()
//    {

//        Destroy(gameObject);
//        //SceneManager.LoadScene("GameOverScreen");
//    }



//    IEnumerator FlashRed()
//    {
//        if (enemyRenderer == null) yield break;

//        enemyRenderer.material.color = Color.red;
//        yield return new WaitForSeconds(0.1f);
//        enemyRenderer.material.color = originalColor;
//    }

//}
