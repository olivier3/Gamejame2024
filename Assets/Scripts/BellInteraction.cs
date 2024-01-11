using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BellInteraction : MonoBehaviour
{
    private int bellActivationCount = 0;
    private bool inBellRange = false;


    // Update is called once per frame
    void Update()
    { 
        if (inBellRange && Input.GetKeyDown(KeyCode.E))
        {
            bellActivationCount++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inBellRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inBellRange = false;
            BellValidation();
        }
    }

    private void BellValidation()
    {
        if (bellActivationCount == 3)
        {
            GameLoop.Instance.AchieveBellInteraction(true);
        }
        else
        {
            GameLoop.Instance.AchieveBellInteraction(false);
            bellActivationCount = 0;
        }
    }

  
}
