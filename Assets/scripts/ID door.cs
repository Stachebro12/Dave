using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDdoor : MonoBehaviour
{
    public GameObject parent;
    private GameObject Canvas;
    public int FakeIDs = 0;

    void Start()
    {
        Canvas = GameObject.Find("HUD");
    }

        public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            FakeIDs = Canvas.GetComponent<Stats>().givenFakeID;
            if (FakeIDs > 0)
            {
                Destroy(parent);
                Canvas.GetComponent<Stats>().Use_FakeID();
            }
        }
    }
}
