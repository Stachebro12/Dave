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
        transform.position = new Vector3(SpawnX, SpawnY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey) && Input.GetKey(rightKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(distD, distD, 0));
            Walk.SetBool("walk", true);
        }
        else if (Input.GetKey(upKey) && Input.GetKey(leftKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(-distD, distD, 0));
            Walk.SetBool("walk", true);
        }
        else if (Input.GetKey(downKey) && Input.GetKey(rightKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(distD, -distD, 0));
            Walk.SetBool("walk", true);
        }
        else if (Input.GetKey(downKey) && Input.GetKey(leftKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(-distD, -distD, 0));
            Walk.SetBool("walk", true);
        }
        else if (Input.GetKey(downKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(0, -distY, 0));
            transform.localRotation = Quaternion.Euler(0, 0, 180);
            Walk.SetBool("walk", true);
        }
        else if (Input.GetKey(upKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(0, distY, 0));
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            Walk.SetBool("walk", true);
        }
        else if (Input.GetKey(rightKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(distX, 0, 0));
            transform.localRotation = Quaternion.Euler(0, 0, 270);
            Walk.SetBool("walk", true);
        }
        else if (Input.GetKey(leftKey))
        {
            rigidBody.MovePosition(transform.position + new Vector3(-distX, 0, 0));
            transform.localRotation = Quaternion.Euler(0, 0, 90);
            Walk.SetBool("walk", true);
        }
        else
        {
            Walk.SetBool("walk", false);
        }
    }
}
