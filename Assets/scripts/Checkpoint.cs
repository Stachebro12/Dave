using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameObject stats;
    public Transform Spawn;
    // Start is called before the first frame update
    void Start()
    {
        stats = GameObject.Find("Stats");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        stats.GetComponent<Stats>().NewSpawnPoint(Spawn);
    }
}
