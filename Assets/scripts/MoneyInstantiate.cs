using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyInstantiate : MonoBehaviour
{
    public KeyCode key;             // which key
    public Transform instantiate;   // causes what to be created?
    public float delayTime;         // what is the minimum time?
    public GameObject player;
    public GameObject moneyHandler;
    public int cost;

    private float moneyAmount;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        moneyAmount = moneyHandler.GetComponentInChildren<Money_count>().MoneyNum;
        // if there's a delay between keypresses imposed, let the time run down
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            return;
        }

        // ok, if there was a delay, it's over with, so we can detect another press
        if (Input.GetKeyDown(key) && moneyAmount > 0)
        {
            Instantiate(instantiate, transform.position, transform.rotation);
            player.GetComponentInChildren<Money_Collect>().UseMoney(-cost);
            timer = delayTime;
        }
    }
}
