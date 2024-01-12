using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class PriereInteraction : MonoBehaviour
{
    private bool inPrayRange = false;
    private GameObject player;
    private Animator animator;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inPrayRange && Input.GetKeyDown(KeyCode.E))
        {
            PriereRidleHandler.PriereValidation(gameObject.name);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inPrayRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inPrayRange = false;
        }
    }
}
