using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    private string scene;

    [SerializeField]
    private GameObject respawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Loading scene " + scene);
            PlayerPrefs.SetFloat("X", respawn.transform.position.x);
            PlayerPrefs.SetFloat("Y", respawn.transform.position.y);
            SceneManager.LoadScene(scene);
        }
    }
}