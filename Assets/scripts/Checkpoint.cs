using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameObject stats;
    public int CheckpointNum;
    public int spawnX;
    public int spawnY;
    public bool checkpoint1 = false;
    public bool checkpoint2 = false;
    public bool checkpoint3 = false;
    public bool checkpoint4 = false;
    public bool checkpoint5 = false;
    public bool checkpoint6 = false;
    public bool checkpoint7 = false;
    public bool checkpoint8 = false;
    public bool checkpoint9 = false;
    public bool checkpoint10 = false;
    // Start is called before the first frame update
    void Awake()
    {
        stats = GameObject.Find("HUD");
        checkpoint1 = stats.GetComponent<Stats>().checkpoint1;
        checkpoint2 = stats.GetComponent<Stats>().checkpoint2;
        checkpoint3 = stats.GetComponent<Stats>().checkpoint3;
        checkpoint4 = stats.GetComponent<Stats>().checkpoint4;
        checkpoint5 = stats.GetComponent<Stats>().checkpoint5;
        checkpoint6 = stats.GetComponent<Stats>().checkpoint6;
        checkpoint7 = stats.GetComponent<Stats>().checkpoint7;
        checkpoint8 = stats.GetComponent<Stats>().checkpoint8;
        checkpoint9 = stats.GetComponent<Stats>().checkpoint9;
        checkpoint10 = stats.GetComponent<Stats>().checkpoint10;
    }
    public void Update()
    {
        if (CheckpointNum == 1)
        {
            if (checkpoint1)
            {
                this.gameObject.SetActive(false);
            }
        }
        if (CheckpointNum == 2)
        {
            if (checkpoint2)
            {
                this.gameObject.SetActive(false);
            }
        }
        if (CheckpointNum == 3)
        {
            if (checkpoint3)
            {
                this.gameObject.SetActive(false);
            }
        }
        if (CheckpointNum == 4)
        {
            if (checkpoint4)
            {
                this.gameObject.SetActive(false);
            }
        }
        if (CheckpointNum == 5)
        {
            if (checkpoint5)
            {
                this.gameObject.SetActive(false);
            }
        }
        if (CheckpointNum == 6)
        {
            if (checkpoint6)
            {
                this.gameObject.SetActive(false);
            }
        }
        if (CheckpointNum == 7)
        {
            if (checkpoint7)
            {
                this.gameObject.SetActive(false);
            }
        }
        if (CheckpointNum == 8)
        {
            if (checkpoint8)
            {
                this.gameObject.SetActive(false);
            }
        }
        if (CheckpointNum == 9)
        {
            if (checkpoint9)
            {
                this.gameObject.SetActive(false);
            }
        }
        if (CheckpointNum == 10)
        {
            if (checkpoint10)
            {
                this.gameObject.SetActive(false);
            }
        }
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
            stats.GetComponentInChildren<Money_count>().GainMoney(100);
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
