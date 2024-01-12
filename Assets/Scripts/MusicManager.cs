using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField]
    private List<AudioSource> musicSources;

    private int srcIndex = 0;
    void Awake()
    {
        musicSources[srcIndex].Play();
        DontDestroyOnLoad(gameObject);

        if(GameObject.FindGameObjectsWithTag("MusicManager").Length > 1 )
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (!musicSources[srcIndex].isPlaying)
        {
            if(srcIndex + 1 > musicSources.Count)
            {
                srcIndex = 0;
            } else
            {
                srcIndex++;
            }

            musicSources[srcIndex].Play();
        }
    }
}
