using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class shop : MonoBehaviour
{
    private GameObject Canvas;
    private GameObject Money;
    public float money;
    public float FTEDictionary_price;
    public float HPCrown_price;
    public float TrenchCoat_price;
    public float FakeID_price;
    public float ToyGun_price;
    public float FacePaint_price;
    public float TeaSet_price;
    public float Saxaphone_price;
    public float EifelTower_price;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("HUD");
        Money = GameObject.Find("Money");
    }

    // Update is called once per frame
    public void Buy_FTEDictionary()
    {
        if (Input.GetMouseButtonDown(0))
        {
            money = Money.GetComponent<Money_count>().MoneyNum;
            if (money >= FTEDictionary_price)
            {
                Money.GetComponent<Money_count>().GainMoney(-FTEDictionary_price);
                Canvas.GetComponent<Stats>().buy_dictionaries();
            }
        }
    }
    public void Buy_HPCrown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            money = Money.GetComponent<Money_count>().MoneyNum;
            if (money >= HPCrown_price)
            {
                Money.GetComponent<Money_count>().GainMoney(-HPCrown_price);
                Canvas.GetComponent<Stats>().buy_HPCrown();
            }
        }
    }
    public void Buy_TrenchCoat()
    {
        if (Input.GetMouseButtonDown(0))
        {
            money = Money.GetComponent<Money_count>().MoneyNum;
            if (money >= TrenchCoat_price)
            {
                Money.GetComponent<Money_count>().GainMoney(-TrenchCoat_price);
                Canvas.GetComponent<Stats>().buy_TrenchCoat();
            }
        }
    }
    public void Buy_FakeID()
    {
        if (Input.GetMouseButtonDown(0))
        {
            money = Money.GetComponent<Money_count>().MoneyNum;
            if (money >= FakeID_price)
            {
                Money.GetComponent<Money_count>().GainMoney(-FakeID_price);
                Canvas.GetComponent<Stats>().buy_FakeID();
            }
        }
    }
    public void Buy_ToyGun()
    {
        if (Input.GetMouseButtonDown(0))
        {
            money = Money.GetComponent<Money_count>().MoneyNum;
            if (money >= ToyGun_price)
            {
                Money.GetComponent<Money_count>().GainMoney(-ToyGun_price);
                Canvas.GetComponent<Stats>().buy_ToyGun();
            }
        }
    }
    public void Buy_FacePaint()
    {
        if (Input.GetMouseButtonDown(0))
        {
            money = Money.GetComponent<Money_count>().MoneyNum;
            if (money >= FacePaint_price)
            {
                Money.GetComponent<Money_count>().GainMoney(-FacePaint_price);
                Canvas.GetComponent<Stats>().buy_FacePaint();
            }
        }
    }
    public void Buy_TeaSet()
    {
        if (Input.GetMouseButtonDown(0))
        {
            money = Money.GetComponent<Money_count>().MoneyNum;
            if (money >= TeaSet_price)
            {
                Money.GetComponent<Money_count>().GainMoney(-TeaSet_price);
                Canvas.GetComponent<Stats>().buy_TeaSet();
            }
        }
    }
    public void Buy_Saxaphone()
    {
        if (Input.GetMouseButtonDown(0))
        {
            money = Money.GetComponent<Money_count>().MoneyNum;
            if (money >= Saxaphone_price)
            {
                Money.GetComponent<Money_count>().GainMoney(-Saxaphone_price);
                Canvas.GetComponent<Stats>().buy_Saxaphone();
            }
        }
    }
    public void Buy_EifelTower()
        {
            if (Input.GetMouseButtonDown(0))
            {
                money = Money.GetComponent<Money_count>().MoneyNum;
                if (money >= EifelTower_price)
                {
                    Money.GetComponent<Money_count>().GainMoney(-EifelTower_price);
                    Canvas.GetComponent<Stats>().buy_EifelTower();
                }
            }
        }
}
