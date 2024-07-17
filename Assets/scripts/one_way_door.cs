using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class one_way_door : MonoBehaviour
{
    public GameObject parent;
    private Animator open;

    void Start()
    {
        open = gameObject.GetComponent<Animator>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            open.SetTrigger("open_door_1");
        }
    }
}
