using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void StartGame()
    {
<<<<<<< Updated upstream
        SceneManager.LoadScene(1);
=======
        SceneManager.LoadScene("LoadingScreen");
>>>>>>> Stashed changes
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
