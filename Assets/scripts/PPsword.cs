using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPsword : MonoBehaviour
{
    public KeyCode attack;
    public GameObject weapon;
    private GameObject pp;
    public float StabTime;
    public int cost;
    
    private float ppAmount;
    private float timer = 0;
    private float DelayTime;
    private void Start()
    {
        pp = GameObject.Find("PP");
    }
    // Update is called once per frame
    void Update()
    {
        ppAmount = pp.GetComponentInChildren<PP>().ppNum;
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            return;
        }

        if (Input.GetKeyDown(attack) && ppAmount > 0)
        {
            weapon.SetActive(true);
            pp.GetComponentInChildren<PP>().UsePP(cost);
            DelayTime = StabTime;
            DelayTime += 0.1f;
            timer = DelayTime;
            StartCoroutine("stab");
        }
    }
    IEnumerator stab()
    {
        yield return new WaitForSeconds(StabTime);
        weapon.SetActive(false);
    }
}
