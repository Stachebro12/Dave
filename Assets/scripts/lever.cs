using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    public bool touching = false;

    public GameObject popup;
    public GameObject door;
    public GameObject pushedLever;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            popup.SetActive(true);
            touching = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            popup.SetActive(false);
            touching = false;
        }
    }

    void Update()
    {
        if (touching)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("push");
                door.SetActive(false);
                pushedLever.SetActive(true);
                this.gameObject.SetActive(false);
            }
        }
    }
}
