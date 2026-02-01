using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour {
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
    public void RestartButton() {
    SceneManager.LoadScene("SampleScene");
    }

public void ExitButton() {
    SceneManager.LoadScene("StartScreen_1");
    }
}