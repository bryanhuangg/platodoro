using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTextController : MonoBehaviour
{
    /// Reference to the PomodoroTimer script
    public PomodoroTimer timer;

    // Update is called once per frame
    void Update()
    {
        if (timer.getIsPaused()) {
            GetComponent<TMPro.TextMeshProUGUI>().text = string.Format("START");
        } else {
            GetComponent<TMPro.TextMeshProUGUI>().text = string.Format("PAUSE");
        }
    }
}
