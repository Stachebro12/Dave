using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameObject stats;
    public int CheckpointNum;
    public int spawnX;
    public int spawnY;
    // Start is called before the first frame update
    void Awake()
    {
        stats = GameObject.Find("HUD");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        stats.GetComponent<Stats>().NewSpawnPoint(spawnX, spawnY);
        if(CheckpointNum == 1)
        {
            stats.GetComponent<Stats>().check1();
        }
        if (CheckpointNum == 2)
        {
            stats.GetComponent<Stats>().check2();
        }
        if (CheckpointNum == 3)
        {
            stats.GetComponent<Stats>().check3();
        }
        if (CheckpointNum == 4)
        {
            stats.GetComponent<Stats>().check4();
        }
        if (CheckpointNum == 5)
        {
            stats.GetComponent<Stats>().check5();
        }
        if (CheckpointNum == 6)
        {
            stats.GetComponent<Stats>().check6();
        }
        if (CheckpointNum == 7)
        {
            stats.GetComponent<Stats>().check7();
        }
        if (CheckpointNum == 8)
        {
            stats.GetComponent<Stats>().check8();
        }
        if (CheckpointNum == 9)
        {
            stats.GetComponent<Stats>().check9();
        }
        if (CheckpointNum == 10)
        {
            stats.GetComponent<Stats>().check10();
        }
    }
}
