using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class chase : MonoBehaviour
{
    public Transform player;
    public float speed = 1f;

    void Start()
    {
        enabled = false;
    }
    void OnBecameVisible()
    {
        enabled = true;
    }
    void Update()
    {
        Vector3 displacement = player.position - transform.position;
        displacement = displacement.normalized;
        if (Vector2.Distance(player.position, transform.position) > 0f)
        {
            transform.position += (displacement * speed * Time.deltaTime);
        }
    }
}
