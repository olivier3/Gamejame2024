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
    private GameObject lampionOff;

    // Update is called once per frame
    void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.E))
        {
            if (isIgnite)
            {
                lampionOn.SetActive(false);
                lampionOff.SetActive(true);
                isIgnite = !isIgnite;
                LampionRidleHandler.DeactivateLampion(gameObject.name);
            }
            else
            {
                lampionOn.SetActive(true);
                lampionOff.SetActive(false);
                isIgnite = !isIgnite;
                LampionRidleHandler.ActivateLampion(gameObject.name);
            }
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
