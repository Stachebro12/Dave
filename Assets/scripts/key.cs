using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponentInChildren<Key_Collect>().PickupKey();
    }
}
