using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class boomerang : MonoBehaviour
{
    public int TTReturn;
    public GameObject playerg;
    public Transform player;
    public float speed = 1f;
    public float velocity;  // this is the speed that I'll move in the direction of my orientation
    public float distToDestroy;

    // Use this for initialization
    void Start()
    {
        playerg = GameObject.Find("Player");

        Quaternion q = transform.rotation;

        Vector3 velocityRotated = q * new Vector3(0, velocity, 0);

        GetComponent<Rigidbody2D>().velocity = velocityRotated;

        StartCoroutine("TurnBack");
        enabled = false;
    }

    void OnCollisionEnter2D()
    {
        enabled = true;
    }

    IEnumerator TurnBack()
    {
        yield return new WaitForSeconds(TTReturn);
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        player = playerg.transform;
        Vector3 displacement = player.position - transform.position;
        displacement = displacement.normalized;
        if (Vector2.Distance(player.position, transform.position) > 0f)
        {
            transform.position += (displacement * speed * Time.deltaTime);
        }
        if (Vector2.Distance(player.position, transform.position) < distToDestroy)
        {
            Destroy (gameObject);
        }
    }
}
