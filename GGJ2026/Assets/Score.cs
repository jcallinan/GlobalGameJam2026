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
            score += 1;
            yield return new WaitForSeconds(1);
        }
        
    }
}
