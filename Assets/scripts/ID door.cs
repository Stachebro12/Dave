using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDdoor : MonoBehaviour
{
    private Animator open;
    private GameObject Canvas;
    public int FakeIDs = 0;

    void Start()
    {
        Canvas = GameObject.Find("HUD");
        open = gameObject.GetComponent<Animator>();
    }

        public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            FakeIDs = Canvas.GetComponent<Stats>().givenFakeID;
            if (FakeIDs > 0)
            {
                open.SetTrigger("open_door_1");
                Canvas.GetComponent<Stats>().Use_FakeID();
            }
        }
    }
}
