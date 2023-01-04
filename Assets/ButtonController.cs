using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    // Reference to the PomodoroTimer script
    public PomodoroTimer timer;

    // Start the timer when the button is clicked
    public void ButtonAction()
    {
        timer.PauseOrStart();
    }
}
