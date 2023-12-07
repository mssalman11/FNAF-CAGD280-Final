using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    public float time;

    private void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        } else if (time < 0)
        {
            time = 0;
        }
        int secs = Mathf.FloorToInt(time % 60);
        switch (secs)
        {
            case 50:
                timerText.text = "1AM";
                break;
            case 40:
                timerText.text = "2AM";
                break;
            case 30:
                timerText.text = "3AM";
                break;
            case 20:
                timerText.text = "4AM";
                break;
            case 10:
                timerText.text = "5AM";
                break;
            case 0:
                timerText.text = "6AM";
                break;
        }
    }
}
