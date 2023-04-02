using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public Transform player;

    void Start()
    {
        enabled = false;
    }
    void OnBecameVisible()
    {
        enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        // what direction do I want to look in?
        Vector3 delta = player.position - transform.position;

        // if we're at the target position, don't rotate -- just keep facing current direction (and don't divide by 0)
        if (delta.x == 0 && delta.y == 0) return;

        // what is the rotation angle (around the Z axis) ; NB, -90 assumes sprite was drawn facing "UP" for an angle of 0
        float angle = Mathf.Rad2Deg * Mathf.Atan2(delta.y, delta.x) - 90.0f;

        // and set the angle
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);	// NB, that's forward in 3d space - z as 1
    }
}
