using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnHit : MonoBehaviour
{
    public GameObject parent;
    void OnCollisionEnter2D()
    {
        Destroy(parent);
    }
}
