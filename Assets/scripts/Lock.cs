using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public GameObject parent;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        float keys = collision.gameObject.GetComponent<Key_Collect>().keyNum;

        if (collision.gameObject.tag.Equals("Player"))
        {
            if (keys > 0)
            {
                Destroy(parent);
                collision.gameObject.GetComponentInChildren<Key_Collect>().UseKey();
            }
        }
    }
}
