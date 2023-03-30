using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPinstantiate : MonoBehaviour
{
    public KeyCode key;             // which key
    public Transform instantiate;   // causes what to be created?
    public float delayTime;         // what is the minimum time?
    public GameObject pp;
    public int cost;

    private float ppAmount;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        ppAmount = pp.GetComponentInChildren<PP>().ppNum;
        // if there's a delay between keypresses imposed, let the time run down
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            return;
        }

        // ok, if there was a delay, it's over with, so we can detect another press
        if (Input.GetKeyDown(key) && ppAmount > 0)
        {
            Instantiate(instantiate, transform.position, transform.rotation);
            pp.GetComponentInChildren<PP>().UsePP(cost);
            timer = delayTime;
        }
    }
}
