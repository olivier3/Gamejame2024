using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampionInteraction : MonoBehaviour
{
    private bool inRange = false;
    private bool isIgnite = false;
    [SerializeField]
    private GameObject lampionOn;
    [SerializeField]
    private AudioSource audioOpen;
    [SerializeField]
    private AudioSource audioClose;

    // Update is called once per frame
    void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.E))
        {
            if (isIgnite)
            {
                LampionRidleHandler.DeactivateLampion(gameObject.name);
                audioClose.Play();
            }
            else
            {
                LampionRidleHandler.ActivateLampion(gameObject.name);
                audioOpen.Play();
            }
            isIgnite = !isIgnite;
            lampionOn.SetActive(isIgnite);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inRange = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inRange = false;
        }
    }
}
