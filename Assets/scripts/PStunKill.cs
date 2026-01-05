using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PStunKill : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<guard>().stunKill();
    }
}
