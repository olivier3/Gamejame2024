using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoatInteraction : MonoBehaviour
{
    private bool inRange = false;
    [SerializeField]
    private AudioSource audio;

    private void Update()
    {

        if (inRange && Input.GetKeyDown(KeyCode.F))
        {
            audio.Play();
            // anim.kiss
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inRange = false;
        }
    }
}
