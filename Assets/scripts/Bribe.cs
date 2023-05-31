using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bribe : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<guard>().bribe();
    }
}
