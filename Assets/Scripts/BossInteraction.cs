using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossInteraction : MonoBehaviour
{
    [SerializeField]
    private List<string> textKeys;
    private int index = 0;
    [SerializeField]
    private GameObject UI;
    [SerializeField]
    private TMP_Text text;
    private bool inRange = false;
    public bool Movement = true;
    bool opened = false;
    bool victory = false;
    [SerializeField]
    private AudioSource audio;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange)
        {
            audio.Play();
            UI.SetActive(true);

            if (!opened)
            {
                opened = true;
                text.text = StoryText.texts[textKeys[index]];
            }
            else
            {
                index = 0;
                opened = false;
                UI.SetActive(false);
                if (victory)
                {
                    SceneManager.LoadScene("Victoire");
                }
                else
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inRange = true;

            if (!GameLoop.Instance.AscendStateReached)
            {
                if (!GameLoop.Instance.SacrificeSuccess)
                {
                    textKeys.Add("FinSacrifice");
                }
                else if (!GameLoop.Instance.BellSuccess)
                {
                    textKeys.Add("FinCloche");
                }
                else if (!GameLoop.Instance.PriereSuccess)
                {
                    textKeys.Add("FinPriere");
                }
                else if (!GameLoop.Instance.LampionSuccess)
                {
                    textKeys.Add("FinLampions");
                }
                else if (!GameLoop.Instance.HasChestKey)
                {
                    textKeys.Add("FinClef");
                }
            }
            else
            {
                textKeys.Add("BonneFin");
                victory = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            index = 0;
            inRange = false;
            UI.SetActive(false);
        }
    }

}
