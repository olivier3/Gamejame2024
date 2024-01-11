using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriereInteraction : MonoBehaviour
{
    private bool inBellRange = false;

    // Update is called once per frame
    void Update()
    {
        if (inBellRange && Input.GetKeyDown(KeyCode.E))
        {
            //start animation to pray
            Debug.Log("You prayed the holy god");
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
        }
    }
}
