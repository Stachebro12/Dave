using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sight : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, Vector2.up);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up);
            if (hit.collider != null)
            {
                Transform target = hit.transform;
                if (target.name == "Player")
                {
                    Debug.Log("seen");
                }
            }
    }
}
