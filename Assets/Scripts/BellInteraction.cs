using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellInteraction : MonoBehaviour
{
    private int bellActivationCount = 0;
    private bool inBellRange = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inBellRange && Input.GetKeyDown(KeyCode.E))
        {
            bellActivationCount++;
            Debug.Log(bellActivationCount + " bell activation");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inBellRange = true;
        }
    }
}
