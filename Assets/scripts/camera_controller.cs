using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    public GameObject player;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (player.transform.position.y - transform.position.y > 5)
        {
                rigidBody.MovePosition(transform.position + new Vector3(0, 10, 0));
        }
        if (player.transform.position.y - transform.position.y < -5)
        {
                rigidBody.MovePosition(transform.position + new Vector3(0, -10, 0));
        }
        if (player.transform.position.x - transform.position.x > 17.8 / 2)
        {
                rigidBody.MovePosition(transform.position + new Vector3((float)1920 / 108, 0, 0));
        }
        if (player.transform.position.x - transform.position.x < -17.8 / 2)
        {
                rigidBody.MovePosition(transform.position + new Vector3((float)-1920 / 108, 0, 0));
        }
    }
}
