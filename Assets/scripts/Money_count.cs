using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_count : MonoBehaviour
{
    public Text Money;

    public float MoneyNum = 0f;

    public GameObject Player;

    public void GainMoney(float difference)
    {
        MoneyNum += difference;
    }
    void Update()
    {
        Money.text = "Money: $" + MoneyNum;
    }
}
