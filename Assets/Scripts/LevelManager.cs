using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public Transform player;


    private void Awake()
    {
        float xpos = PlayerPrefs.GetFloat("X", 4.33f);
        float ypos = PlayerPrefs.GetFloat("Y", -20f);
        float zpos = PlayerPrefs.GetFloat("Z", 2f);
        player.transform.position = new Vector3(xpos, ypos, zpos);
    }
}
