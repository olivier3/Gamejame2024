using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour
{
    /*
    [SerializeField]
    private string collisionTag;
    [SerializeField]
    private string[] textKeys;
    private int? index = null;
    [SerializeField]
    private GameObject touche;
    [SerializeField]
    private GameObject UI;
    [SerializeField]
    private TextMeshPro text;
    public bool Movement = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == collisionTag)
        {
            text.text = StoryText.texts[textKeys[index]];

            touche.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Q))
            {
                touche.SetActive(false);
                if (index is null )
                {
                    index = 0;
                } 
                else if (index < textKeys.Length)
                {
                    index++;
                    text.text = StoryText.texts[textKeys[index]];
                }
                else
                {
                    index = null;
                    UI.SetActive(false);
                    touche.SetActive(true);
                }
            }
        }
    }
    */
}
