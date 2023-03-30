using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money_Collect : MonoBehaviour
{
    public float MoneyNum = 0f;

    public void PickupMoney(int amount)
    {
        MoneyNum += amount;
    }

    public void UseMoney(int amount)
    {
        MoneyNum -= amount;
    }
}
