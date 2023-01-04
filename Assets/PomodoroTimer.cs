using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PomodoroTimer : MonoBehaviour
{
    public float workPeriodLength = 25.0f;
    public float breakPeriodLength = 5.0f;
    public float timeRemaining;
    public bool isWorkPeriod;
    public bool isPaused = false;

    public void StartTimer()
    {
        timeRemaining = workPeriodLength * 60.0f;
        isWorkPeriod = true;
    }

    // Update the timer every frame
    void Update()
    {
        if (!isPaused)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0.0f)
            {
                if (isWorkPeriod)
                {
                    StartBreakPeriod();
                }
                else
                {
                    StartWorkPeriod();
                }
            }
        }
    }

    // Start the break period
    public void StartBreakPeriod()
    {
        timeRemaining = breakPeriodLength * 60.0f;
        isWorkPeriod = false;
    }

    // Start the work period
    public void StartWorkPeriod()
    {

        timeRemaining = workPeriodLength * 60.0f;
        isWorkPeriod = true;
    }

    public void PauseOrStart()
    {
        isPaused = !isPaused;
    }

    public bool getIsPaused(){
        return isPaused;
    }

    public bool getStatus(){
        return isWorkPeriod;
    }
}
