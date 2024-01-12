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
    private int ritualStepCompleted = 0;
    public bool sacrificeDone = false;
    public bool hasChestKey { get; private set; } = false;
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
        ritualStepCompleted = 1;
        hasChestKey = false;
        AscendStateReached = false;
    }

    public void PickUpChestKey()
    {
        hasChestKey = true;
    }

    public void Sacrifice()
    {
        sacrificeDone = true;
    }

    public void AchieveBellInteraction(bool result)
    {
        if (result)
        {
            bellSuccess = true;
            ritualStepCompleted++;
            RitualValidation();
        }
        else
        {
            if (bellSuccess && ritualStepCompleted > 1)
            {
                bellSuccess = false;
                ritualStepCompleted--;
                RitualValidation();
            }
        }
    }

    public void AchieveLampionInteraction(bool result)
    {
        if (result)
        {
            lampionSuccess = true;
            ritualStepCompleted++;
            RitualValidation();
        }
        else
        {
            if (lampionSuccess && ritualStepCompleted > 1)
            {
                lampionSuccess = false;
                ritualStepCompleted--;
                RitualValidation();
            }
        }
    }

    public void AchievePriereInteraction(bool result)
    {
        if (result)
        {
            priereSuccess = true;
            ritualStepCompleted++;
            RitualValidation();
        }
        else
        {
            if (priereSuccess && ritualStepCompleted > 1)
            {
                priereSuccess = false;
                ritualStepCompleted--;
                RitualValidation();
            }
        }
    }

    public void AchieveSacrificeInteraction()
    {
        sacrificeSuccess = true;
        ritualStepCompleted++;
        RitualValidation();
    }

    public void AchievePasswordInteraction()
    {
        passwordSuccess = true;
        ritualStepCompleted++;
        RitualValidation();
    }

    public void FailChestInteraction()
    {
        ritualStepCompleted--;
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
