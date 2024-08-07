using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter_item : MonoBehaviour
{
    public KeyCode key;             // which key
    public Transform instantiate;   // causes what to be created?
    public float delayTime;         // what is the minimum time?
    public GameObject player;

    private float ItemAmmo;
    private float timer = 0;
    private GameObject canvas;

    private void Awake()
    {
        canvas = GameObject.Find("HUD");
    }

    // Update is called once per frame
    void Update()
    {
        ItemAmmo = canvas.GetComponent<Stats>().givenToyGun;
        // if there's a delay between keypresses imposed, let the time run down
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            return;
        }

        // ok, if there was a delay, it's over with, so we can detect another press
        if (Input.GetKeyDown(key) && ItemAmmo > 0)
        {
            Instantiate(instantiate, transform.position, transform.rotation);
            canvas.GetComponent<Stats>().Use_ToyGun();
            timer = delayTime;
        }
    }
}
