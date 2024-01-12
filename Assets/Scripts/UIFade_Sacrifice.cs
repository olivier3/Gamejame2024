using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIFade_Sacrifice : MonoBehaviour
{
    [SerializeField]
    private Image touche;
    [SerializeField]
    private TMP_Text text;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {

            StartCoroutine(FadeImage(false));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            StartCoroutine(FadeImage(true));
        }
    }

    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime * 5)
            {
                // set color with i as alpha
                touche.color = new Color(1, 1, 1, i);
                text.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
        // fade from transparent to opaque
        else
        {
            // loop over 1 second
            for (float i = 0; i <= 1; i += Time.deltaTime * 5)
            {
                // set color with i as alpha
                touche.color = new Color(1, 1, 1, i);
                text.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
    }
}
