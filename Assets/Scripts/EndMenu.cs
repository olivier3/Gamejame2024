using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void PlayGame()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(1); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
