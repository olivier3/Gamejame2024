using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour
{
    [SerializeField]
    private string[] textKeys;
    private int index = 0;
    [SerializeField]
    private GameObject UI;
    [SerializeField]
    private TMP_Text text;
    private bool inRange = false;
    private bool opened = false;
    public bool Movement = true;
    [SerializeField]
    private AudioSource[] audio;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange)
        {
            UI.SetActive(true);
            if (!opened)
            {
                opened = true;
                audio[index].Play();
            }
            else if (index < textKeys.Length - 1)
            {
                index++;
                audio[0].Play();
                text.text = StoryText.texts[textKeys[index]];
            }
            else
            {
                index = 0;
                opened= false;
                UI.SetActive(false);
            }
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            text.text = StoryText.texts[textKeys[index]];
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
            text.text = StoryText.texts[textKeys[index]];
        }
    }

}
