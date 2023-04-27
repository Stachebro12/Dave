using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_Manager : MonoBehaviour {
    public float moneyNum = 0f;
    public Text moneyValue;

    void Awake() {
        moneyValue = GameObject.Find("Money_Value").GetComponent<Text>();
    }

    void Start() {
        moneyValue.text = "Money: $" + moneyNum;
    }

    public void ChangeMoney(int amount) {
        moneyNum += amount;
        moneyValue.text = "Money: $" + moneyNum;
    }
}