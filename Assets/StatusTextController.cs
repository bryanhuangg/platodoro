using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusTextController : MonoBehaviour
{
    // Reference to the PomodoroTimer script
    public PomodoroTimer timer;

    // Update is called once per frame
    void Update()
    {
        if (timer.getStatus()) {
            GetComponent<Text>().text = string.Format("WORK");
        } else {
            GetComponent<Text>().text = string.Format("BREAK");
        }
        
    }
}
