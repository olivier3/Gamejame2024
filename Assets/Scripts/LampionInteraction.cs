using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampionInteraction : MonoBehaviour
{
    [SerializeField]
    private GameObject touche;

    [SerializeField]
    private string brocTag;
    [SerializeField]
    private GameObject brocObject;
    public bool goodChoice = false;

    [SerializeField]
    private string dollTag;
    [SerializeField]
    private GameObject dollObject;

    [SerializeField]
    private string goatTag;
    [SerializeField]
    private GameObject goatObject;

    [SerializeField]
    private string mickeyTag;
    [SerializeField]
    private GameObject mickeyObject;

    private bool choiceMade = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        touche.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E) && !choiceMade)
        {
            touche.SetActive(false);
            if (collision.collider.tag == brocTag)
            {
                goodChoice = true;
                Destroy(brocObject);
            }

            if (collision.collider.tag == dollTag)
            {
                Destroy(dollObject);
            }

            if (collision.collider.tag == goatTag)
            {
                Destroy(goatObject);
            }

            if (collision.collider.tag == mickeyTag)
            {
                Destroy(mickeyObject);
            }

        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == brocTag || collision.collider.tag == goatTag
            || collision.collider.tag == dollTag || collision.collider.tag == mickeyTag)
        {
            touche.SetActive(false);
        }
    }
}
