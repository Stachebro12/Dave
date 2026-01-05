using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public int Value;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponentInChildren<Money_Collect>().PickupMoney(Value);
    }
}
