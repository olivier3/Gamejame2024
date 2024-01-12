using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    private bool inChestRange = false;
    private bool opened = false;
    [SerializeField]
    private GameObject chestClosed;
    [SerializeField]
    private GameObject chestOpen;
    [SerializeField]
    private AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        if (inChestRange && Input.GetKeyDown(KeyCode.E))
        {
            if (GameLoop.Instance.HasChestKey && !opened)
            {
                opened = true;
                audioSource.Play();
                GameLoop.Instance.FailChestInteraction();
                chestClosed.SetActive(false);
                chestOpen.SetActive(true);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inChestRange = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inChestRange = false;
        }
    }
}
