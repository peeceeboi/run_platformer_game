using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public static string CurrentScene;

    public void OnButtonClick()
    {
        if (gameObject.name == "PlayButton")
        {
            SceneManager.LoadScene("LevelSelector");
        }
        if (gameObject.name == "HomeButton")
        {
            SceneManager.LoadScene("MainMenu");
        }
        if (gameObject.name == "Level1")
        {
            SceneManager.LoadScene("Level1");
            CurrentScene = "Level1";
        }
        if (gameObject.name == "Controls")
        {
            SceneManager.LoadScene("Controls");
        }
    }
    public void Exit()
    {
        Application.Quit();
    }
}
