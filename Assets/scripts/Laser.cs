using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Laser : MonoBehaviour
{
    public GameObject laser;
    public float onTime;
    public float offTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LaserOn");
    }

    IEnumerator LaserOn()
    {
        laser.SetActive(true);
        yield return new WaitForSeconds(onTime);
        StartCoroutine("LaserOff");
    }

    IEnumerator LaserOff()
    {
        laser?.SetActive(false);
        yield return new WaitForSeconds(offTime);
        StartCoroutine("LaserOn");
    }
}
