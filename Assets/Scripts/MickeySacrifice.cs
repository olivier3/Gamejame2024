using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MickeySacrifice : MonoBehaviour
{
    private bool inZone = false;
    [SerializeField]
    private GameObject mickey;
    [SerializeField]
    private GameObject sacrificedGameObject;
    [SerializeField]
    private GameObject blackScreen;
    // Update is called once per frame
    void Update()
    {
        if (inZone && Input.GetKeyDown(KeyCode.E) && GameLoop.Instance.sacrificeDone)
        {
            Destroy(mickey);
            GameLoop.Instance.Sacrifice();
            blackScreen.SetActive(true);
            Invoke("Disappear", 1);
            sacrificedGameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            inZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inZone = false;
        }
    }

    private void Disappear()
    {
        blackScreen.SetActive(false);
    }
}
