using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriereRidleHandler : MonoBehaviour
{
    private const string goodPray = "PriereMeditation";

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
