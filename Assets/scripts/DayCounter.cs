using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DayCounter : MonoBehaviour
{
    public int day = 1;
    public Text DayText;

    public void timePassing()
    {
        day++;
    }
    void Update()
    {
        if (day == 1)
        {
            DayText.text = "Day 1";
        } 
        else if (day == 2)
        {
            DayText.text = "Night 1";
        }
        else if (day == 3)
        {
            DayText.text = "Day 2";
        }
        else if (day == 4)
        {
            DayText.text = "Night 2";
        }
        else if (day == 5)
        {
            DayText.text = "Day 3";
        }
        else if (day == 6)
        {
            DayText.text = "Night 3";
        }
        else if (day == 7)
        {
            DayText.text = "Day 4";
        }
        else if (day == 8)
        {
            DayText.text = "Night 4";
        }
        else if (day == 9)
        {
            DayText.text = "Day 5";
        }
        else if (day == 10)
        {
            DayText.text = "Night 5";
        }
        else if (day == 11)
        {
            DayText.text = "Day 6";
        }
        else if (day == 12)
        {
            DayText.text = "Night 6";
        }
        else if (day == 13)
        {
            DayText.text = "Day 7";
        }
        else if (day == 14)
        {
            DayText.text = "Night 7";
        }
    }
}
