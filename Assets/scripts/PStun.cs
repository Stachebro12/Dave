using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PStun : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<guard>().stunHit();
    }
}
