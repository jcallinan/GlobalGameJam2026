using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public int score = 0;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateEverySecondRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();

    }
    IEnumerator UpdateEverySecondRoutine()
    {
        while (true)
        {
            var stealth = GameObject.FindGameObjectWithTag("Player")
    .GetComponent<PlayerStealth>();

        if (stealth == null || stealth.CanScore())
        {
            score += 1;
        }
            
            yield return new WaitForSeconds(1);
        }
        //
        

    //
}
    //public void SaveBestScore()
    //{
    //    int bestScore = PlayerPrefs.GetInt("BestScore", 0);

    //    if (score > bestScore)
    //    {
    //        PlayerPrefs.SetInt("BestScore", score);
    //        PlayerPrefs.Save();
    //    }
    //}

    public void SaveBestScore()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        Debug.Log($"[SaveBestScore] current={score} best(before)={bestScore}");

        PlayerPrefs.SetInt("LastScore", score); // optional but handy

        if (score > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", score);
            PlayerPrefs.Save();
           
        }
        else
        {
        }
    }
}
