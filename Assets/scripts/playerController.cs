using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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
    private int SpawnX;
    private int SpawnY;
    private GameObject Stats;
    private GameObject pp;
    private Animator Walk;
    private bool spawned = false;


    // Start is called before the first frame update
    void Start()
    {
        Walk = GetComponent<Animator>();
        pp = GameObject.Find("PP");
        Stats = GameObject.Find("HUD");
        SpawnX = Stats.GetComponent<Stats>().SpawnX;
        SpawnY = Stats.GetComponent<Stats>().SpawnY;
        rigidBody = GetComponent<Rigidbody2D> ();
        pp.GetComponent<PP>().RestorePP();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawned == false)
        {
            rigidBody.MovePosition(new Vector3(SpawnX, SpawnY, 0));
            GetComponent<BoxCollider2D>().enabled = false;
            if (transform.position.x == SpawnX & transform.position.y == SpawnY)
            {
                spawned = true;
                GetComponent<BoxCollider2D>().enabled = true;
            }
        }
        if (Input.GetKey(downKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(0, -distY, 0));
            transform.localRotation = Quaternion.Euler(0, 0, 180);
            Walk.SetTrigger("move");
        }
        if (Input.GetKey(upKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(0, distY, 0));
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            Walk.SetTrigger("move");
        }
        if (Input.GetKey(rightKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(distX, 0, 0));
            transform.localRotation = Quaternion.Euler(0, 0, 270);
            Walk.SetTrigger("move");
        }
        if (Input.GetKey(leftKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(-distX, 0, 0));
            transform.localRotation = Quaternion.Euler(0, 0, 90);
            Walk.SetTrigger("move");
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
        if (!Input.anyKey)
        {
            Walk.SetTrigger("stop");
        }
    }
}
