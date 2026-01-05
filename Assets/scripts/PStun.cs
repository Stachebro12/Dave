using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PStun : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<guard>()) {
            collision.gameObject.GetComponent<guard>().stunHit();
        }
    }
}
