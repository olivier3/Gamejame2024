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
    [SerializeField]
    private AudioSource audio;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audio.Play();
            if (respawn != null)
            {
                PlayerPrefs.SetFloat("X", respawn.transform.position.x);
                PlayerPrefs.SetFloat("Y", respawn.transform.position.y);
            }
            SceneManager.LoadScene(scene);
        }
    }
}