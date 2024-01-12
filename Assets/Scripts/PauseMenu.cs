using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    private bool IsActive => gameObject.activeSelf;

    public void Toggle()
    {
        gameObject.SetActive(!IsActive);
        
        if (IsActive)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    public void Resume()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1f;

    }

    public void Pause()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
