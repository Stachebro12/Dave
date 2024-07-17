using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money_Collect : MonoBehaviour
{
    private GameObject canvas;
    private bool x2;
    private bool x10;

    private void Awake()
    {
        canvas = GameObject.Find("HUD");
        x2 = canvas.GetComponent<Stats>().checkpoint5;
        x10 = canvas.GetComponent<Stats>().checkpoint9;
    }
    public void PickupMoney(float amount)
    {
        if (x10)
        {
            amount = amount * 10;
        } 
        else if (x2)
        {
            amount = amount * 2;
        }
        canvas.GetComponentInChildren<Money_count>().GainMoney(amount);
    }

    public void UseMoney(float amount)
    {
        canvas.GetComponentInChildren<Money_count>().GainMoney(amount);
    }
}
