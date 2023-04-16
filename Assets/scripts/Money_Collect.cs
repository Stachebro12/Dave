using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money_Collect : MonoBehaviour
{
    public GameObject Money;

    public void PickupMoney(float amount)
    {
        Money.GetComponentInChildren<Money_count>().GainMoney(amount);
    }

    public void UseMoney(float amount)
    {
        Money.GetComponentInChildren<Money_count>().GainMoney(amount);
    }
}
