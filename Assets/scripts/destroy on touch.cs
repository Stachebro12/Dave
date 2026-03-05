using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyontouch : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        Destroy(this.gameObject);
    }
}
