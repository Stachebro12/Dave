using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class one_way_door : MonoBehaviour
{
    public GameObject parent;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(parent);
        }
    }
}
