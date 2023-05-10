using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money_Collect : MonoBehaviour
{
    private GameObject canvas;

    private void Awake()
    {
        canvas = GameObject.Find("HUD");
    }
    public void PickupMoney(float amount)
    {
        canvas.GetComponentInChildren<Money_count>().GainMoney(amount);
    }

    public void UseMoney(float amount)
    {
        canvas.GetComponentInChildren<Money_count>().GainMoney(amount);
    }
}
