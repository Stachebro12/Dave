using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PP : MonoBehaviour
{
    public Text PPText;

    public float ppNum;

    // Update is called once per frame
    public void UsePP(int cost)
    {
        ppNum -= cost;
    }
    void Update()
    {
        PPText.text = "PP: " + ppNum;
    }
}
