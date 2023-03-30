using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_count : MonoBehaviour
{
    public Text Money;

    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        float money = Player.GetComponent<Money_Collect>().MoneyNum;

        Money.text = "Money: $" + money;
    }
}
