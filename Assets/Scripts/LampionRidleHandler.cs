using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class LampionRidleHandler : MonoBehaviour
{
    private static List<string> activeLampionList = new List<string>();

    public static void ActivateLampion(string lampionName)
    {
        activeLampionList.Add(lampionName);

        ActivatedLampionValidation();
    }

    public static void DeactivateLampion(string lampionName)
    {
        int index = activeLampionList.IndexOf(lampionName);

        activeLampionList.RemoveAt(index);

        ActivatedLampionValidation();
    }

    private static void ActivatedLampionValidation()
    {
        if (activeLampionList.Count == 2 && activeLampionList.Contains("LampionWest") && activeLampionList.Contains("LampionEast"))
        {
            GameLoop.Instance.AchieveLampionInteraction(true);
        }
        else{
            GameLoop.Instance.AchieveLampionInteraction(false);
        }
    }
}
