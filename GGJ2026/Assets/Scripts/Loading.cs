using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public GameObject loadingPanel; // Assign your loading screen UI here
    public string nextSceneName;    // Name of the scene to load

    public float waitTime = 5f;     // seconds to show loading screen

    void Start()
    {
        // Make sure the panel is active
        if (loadingPanel != null)
            loadingPanel.SetActive(true);

        // Start the loading coroutine
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        // Wait for specified time
        yield return new WaitForSeconds(waitTime);

        // Load the next scene
        SceneManager.LoadScene("SampleScene");
    }
}