using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;

    public float distX;
    public float distY;
    public float distD;

    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(downKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(0, -distY, 0));
        }
        if (Input.GetKey(upKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(0, distY, 0));
        }
        if (Input.GetKey(rightKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(distX, 0, 0));
        }
        if (Input.GetKey(leftKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(-distX, 0, 0));
        }
        if (Input.GetKey(upKey) && Input.GetKey(rightKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(distD, distD, 0));
        }
        if (Input.GetKey(upKey) && Input.GetKey(leftKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(-distD, distD, 0));
        }
        if (Input.GetKey(downKey) && Input.GetKey(rightKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(distD, -distD, 0));
        }
        if (Input.GetKey(downKey) && Input.GetKey(leftKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(-distD, -distD, 0));
        }
    }
}
