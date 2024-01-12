using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuGameObject;

    private PauseMenu pauseMenu;

    private void Start()
    {
        pauseMenu = pauseMenuGameObject.GetComponent<PauseMenu>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.Toggle();
        }
    }
}
