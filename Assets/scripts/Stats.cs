using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {
    public int dateNum;
    public int SpawnX;
    public int SpawnY;
    public int alienNum;
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
    public bool TEWon = false;

    private GameObject gift;

    void Start() {
        DontDestroyOnLoad(this.gameObject); //This is necessary to ensure the HUD carries between scenes.
    }

    public void dateUp() {
        dateNum += 1;
    }

    public void NewSpawnPoint(int SpawnPointX, int SpawnPointY)
    {
        SpawnX = SpawnPointX;
        SpawnY = SpawnPointY;
    }

    public void check1()
    {
        checkpoint1 = true;
    }
    public void check2()
    {
        checkpoint2 = true;
    }
    public void check3()
    {
        checkpoint3 = true;
    }
    public void check4()
    {
        checkpoint4 = true;
    }
    public void check5()
    {
        checkpoint5 = true;
    }
    public void check6()
    {
        checkpoint6 = true;
    }
    public void check7()
    {
        checkpoint7 = true;
    }
    public void check8()
    {
        checkpoint8 = true;
    }
    public void check9()
    {
        checkpoint9 = true;
    }
    public void check10()
    {
        checkpoint10 = true;
    }
    public void TEWin()
    {
        TEWon = true;
    }
}