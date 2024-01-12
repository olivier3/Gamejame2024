using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    public bool BellSuccess { get; private set; } = false;
    public bool LampionSuccess { get; private set; } = false;
    public bool PriereSuccess { get; private set; } = false;
    public bool SacrificeSuccess { get; private set; } = false;
    public bool PasswordSuccess { get; private set; } = false;
    private int ritualStepCompleted = 0;
    public bool HasChestKey { get; private set; } = false;
    public bool ChestOpened { get; private set; } = false;
    public bool AscendStateReached { get; private set; } = false;

    private static GameLoop _instance;
    public bool sacrificeDone = false;


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
        BellSuccess = false;
        LampionSuccess = false;
        PriereSuccess = false;
        SacrificeSuccess = false;
        PasswordSuccess = false;
        ritualStepCompleted = 1;
        HasChestKey = false;
        AscendStateReached = false;
        sacrificeDone = false;
    }

    public void PickUpChestKey()
    {
        HasChestKey = true;
        ritualStepCompleted++;
        RitualValidation();
    }

    public void Sacrifice()
    {
        sacrificeDone = true;
    }

    public void AchieveBellInteraction(bool result)
    {
        if (result)
        {
            BellSuccess = true;
            ritualStepCompleted++;
            RitualValidation();
        }
        else
        {
            if (BellSuccess && ritualStepCompleted > 1)
            {
                BellSuccess = false;
                ritualStepCompleted--;
                RitualValidation();
            }
        }
    }

    public void AchieveLampionInteraction(bool result)
    {
        if (result)
        {
            LampionSuccess = true;
            ritualStepCompleted++;
            RitualValidation();
        }
        else
        {
            if (LampionSuccess && ritualStepCompleted > 1)
            {
                LampionSuccess = false;
                ritualStepCompleted--;
                RitualValidation();
            }
        }
    }

    public void AchievePriereInteraction(bool result)
    {
        
    }

    public void AchieveSacrificeInteraction()
    {
        SacrificeSuccess = true;
        ritualStepCompleted++;
        RitualValidation();
    }

    public void AchievePasswordInteraction()
    {
        PasswordSuccess = true;
        ritualStepCompleted++;
        RitualValidation();
    }

    public void FailChestInteraction()
    {
        ChestOpened = true;
        ritualStepCompleted--;
        RitualValidation();
    }

    private void RitualValidation()
    {
        if (ritualStepCompleted >= 5)
        {
            AscendStateReached = true;
        }
    }
}
