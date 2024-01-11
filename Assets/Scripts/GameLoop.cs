using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    private bool bellSuccess = false;
    private bool lampionSuccess = false;
    private bool priereSuccess = false;
    private bool sacrificeSuccess = false;
    private bool passwordSuccess = false;
    private bool chestSuccess = false;
    private int ritualStepCompleted = 0;
    public bool AscendStateReached { get; private set; } = false;
    private static GameLoop _instance;

    public static GameLoop Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void ResetAllState()
    {
        bellSuccess = false;
        lampionSuccess = false;
        priereSuccess = false;
        sacrificeSuccess = false;
        passwordSuccess = false;
        chestSuccess = false;
        ritualStepCompleted = 0;
        AscendStateReached = false;
    }

    public void AcheiveBellInteraction(bool result)
    {
        if (result)
        {
            bellSuccess = true;
            ritualStepCompleted++;
            RitualValidation();
        }
        else
        {
            if (bellSuccess == true && ritualStepCompleted > 0)
            bellSuccess = false;
            ritualStepCompleted--;
            RitualValidation();
        }
    }

    public void AcheiveLampionInteraction(bool result)
    {
        lampionSuccess = true;
        ritualStepCompleted++;
        RitualValidation();
    }

    public void AcheivePriereInteraction()
    {
        priereSuccess = true;
        ritualStepCompleted++;
        RitualValidation();
    }

    public void AcheiveSacrificeInteraction()
    {
        sacrificeSuccess = true;
        ritualStepCompleted++;
        RitualValidation();
    }

    public void AcheivePasswordInteraction()
    {
        passwordSuccess = true;
        ritualStepCompleted++;
        RitualValidation();
    }

    public void AcheiveChestInteraction()
    {
        chestSuccess = true;
        ritualStepCompleted++;
        RitualValidation();
    }

    private void RitualValidation()
    {
        if (ritualStepCompleted >= 6)
        {
            AscendStateReached = true;
        }
    }
}
