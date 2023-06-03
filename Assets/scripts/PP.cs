using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PP : MonoBehaviour
{
    public Text PPText;

    public float ppNum;
    public float ppMax;

    // Update is called once per frame
    public void UsePP(int cost)
    {
        ppNum -= cost;
    }
    public void IncreasePP(int Gains)
    {
        ppMax += Gains;
    }

    public void RestorePP()
    {
        ppNum = ppMax;
    }

    void Update()
    {
        PPText.text = "PP: " + ppNum + "/" + ppMax;
    }
}
