using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    // Reference to the PomodoroTimer script
    public PomodoroTimer timer;

    // Update the text element to display the current time remaining
    void Update()
    {
        // Convert the current time remaining from seconds to minutes
        float minutes = Mathf.Floor(timer.timeRemaining / 60.0f);

        // Convert the current time remaining from seconds to seconds
        float seconds = Mathf.RoundToInt(timer.timeRemaining % 60.0f);

        // Display the current time remaining in the format "MM:SS"
        GetComponent<Text>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
