using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class sword : MonoBehaviour
{
    public KeyCode attack;
    public GameObject weapon;
    public float StabTime;

    private float timer = 0;
    private float DelayTime;
    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            return;
        }

        if (Input.GetKeyDown(attack))
        {
            weapon.SetActive(true);
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
