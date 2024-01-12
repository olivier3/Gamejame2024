using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoatSacrifice : MonoBehaviour
{
    private bool inZone = false;
    [SerializeField]
    private GameObject goat;
    [SerializeField]
    private GameObject sacrificedGameObject;
    [SerializeField]
    private GameObject blackScreen;
    [SerializeField]
    private AudioSource thunder;
    [SerializeField]
    private Animator playerAnimator;
    // Update is called once per frame
    void Update()
    {
        if (inZone && Input.GetKeyDown(KeyCode.E) && !GameLoop.Instance.sacrificeDone)
        {
            Destroy(goat);
            thunder.Play();
            GameLoop.Instance.Sacrifice();
            blackScreen.SetActive(true);
             Invoke("Disappear", 1);
            sacrificedGameObject.SetActive(true);
        
    }
        if (inZone && Input.GetKeyDown(KeyCode.F))
        {
            playerAnimator.SetTrigger("IsPetting");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
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
