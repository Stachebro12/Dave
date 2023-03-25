using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class sword : MonoBehaviour
{
    public KeyCode attack;
    public GameObject weapon;
    public float StabTime;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(attack))
        {
            weapon.SetActive(true);
            StartCoroutine("stab");
        }
    }
    IEnumerator stab()
    {
        yield return new WaitForSeconds(StabTime);
        weapon.SetActive(false);
    }
}
