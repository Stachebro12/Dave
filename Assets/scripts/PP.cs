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
        PPText.text = "PP: " + ppNum + "/" + ppMax;
    }
    public void IncreasePP(int Gains)
    {
        ppMax += Gains;
        if (ppNum > -Gains)
        {
            ppNum += Gains;
            PPText.text = "PP: " + ppNum + "/" + ppMax;
        }
    }

    public void RestorePP()
    {
        ppNum = ppMax;
        PPText.text = "PP: " + ppNum + "/" + ppMax;
    }

    void Start()
    {
        PPText.text = "PP: " + ppNum + "/" + ppMax;
    }
}
