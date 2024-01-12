using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class BookInteraction : MonoBehaviour
{
    
    [SerializeField]
    private string textKey;
    [SerializeField]
    private GameObject UI;
    [SerializeField]
    private TMP_Text text;
    private bool inRange = false;
    private bool opened = false;


    private void Start()
    {
        text.text = StoryText.texts[textKey + "1"];
    }

    private void Update()
    {

        if (opened && inRange && Input.GetKeyDown(KeyCode.E))
        {
            text.text = StoryText.texts[textKey + "2"];
        }
        else if (inRange && Input.GetKeyDown(KeyCode.E))
        {
            opened = true;
            UI.SetActive(true);
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
            opened = false;
            UI.SetActive(false);
            text.text = StoryText.texts[textKey + "1"];
        }
    }

}
