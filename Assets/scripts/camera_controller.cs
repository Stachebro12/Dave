using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        if (player.position.y - transform.position.y > 5)
        {
            transform.Translate(0, 10, 0);
        }
        if (player.position.y - transform.position.y < -5)
        {
            transform.Translate(0, -10, 0);
        }
        if (player.position.x - transform.position.x > 17.8 / 2)
        {
            transform.Translate((float)1920 / 108, 0, 0);
        }
        if (player.position.x - transform.position.x < -17.8 / 2)
        {
            transform.Translate((float)-1920 / 108, 0, 0);
        }
    }
}
