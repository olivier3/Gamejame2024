using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriereRidleHandler : MonoBehaviour
{
    private const string goodPray = "PriereMeditation";
    private GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public static void PriereValidation(string nomPriere)
    {
        if (nomPriere.Equals(goodPray))
        {
            GameLoop.Instance.AchievePriereInteraction(true);
        }
        else
        {
            GameLoop.Instance.AchievePriereInteraction(false);
        }
    }
}
