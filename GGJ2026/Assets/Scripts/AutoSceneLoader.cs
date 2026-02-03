using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoSceneLoader : MonoBehaviour
{
    public string nextSceneName = "SampleScene";
    public float delay = 3f;

    void Start()
    {
        Invoke(nameof(LoadNextScene), delay);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
