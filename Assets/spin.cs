using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public PomodoroTimer timer;
    private int multiplyer;

    // Update is called once per frame
    void Update()
    {
        if (timer.getIsPaused() || !timer.getStatus()) {
            multiplyer = 5;
        } else {
            multiplyer = 25;
        }

        transform.Rotate(0f, multiplyer * Time.deltaTime, 0f, Space.Self);
    }
}
