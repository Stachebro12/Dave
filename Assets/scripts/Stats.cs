using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.WSA;

public class Stats : MonoBehaviour {
    public int dateNum;
    private int origiDate;
    private bool canContinue = false;
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

    public int dictionaries = 0;
    public int HPCrown = 0;
    public int TrenchCoat = 0;
    public int FakeID = 0;
    public int ToyGun = 0;
    public int FacePaint = 0;
    public int TeaSet = 0;
    public int Saxaphone = 0;
    public int EifelTower = 0;

    public int givenDictionaries = 0;
    public int givenHPCrown = 0;
    public int givenTrenchCoat = 0;
    public int givenFakeID = 0;
    public int givenToyGun = 0;
    public int givenFacePaint = 0;
    public int givenTeaSet = 0;
    public int givenSaxaphone = 0;
    public int givenEifelTower = 0;

    private DayCounter dayCounter;

    private GameObject gift;

    private void Awake()
    {
        dayCounter = GetComponentInChildren<DayCounter>();
    }

    void Start() {
        DontDestroyOnLoad(this.gameObject); //This is necessary to ensure the HUD carries between scenes.
        origiDate = dateNum;
    }

    public void dateUp() {
        dateNum++;
        if (dateNum == origiDate + 6 && alienNum != 3) {
            int pp = dayCounter.PP;
            int PPRequirement = dayCounter.PPRequirement;
            if (pp >= 0) {
                dateNum++;
                canContinue = true;
            }
            if (pp >= PPRequirement) {
                dateNum++;
            }
        } else if (canContinue == true) {
            if (alienNum == 1) {
                dateNum = 13;
            }
            if (alienNum == 2) {
                dateNum = 26;
            }
        }
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
    public void buy_dictionaries()
    {
        dictionaries++;
    }
    public void buy_HPCrown()
    {
        HPCrown++;
    }
    public void buy_TrenchCoat()
    {
        TrenchCoat++;
    }
    public void buy_FakeID()
    {
        FakeID++;
    }
    public void buy_ToyGun()
    {
        ToyGun++;
    }
    public void buy_FacePaint()
    {
        FacePaint++;
    }
    public void buy_TeaSet()
    {
        TeaSet++;
    }
    public void buy_Saxaphone()
    {
        Saxaphone++;
    }
    public void buy_EifelTower()
    {
        EifelTower++;
    }
    public void give_dictionaries()
    {
        dictionaries--;
        givenDictionaries++;
    }
    public void give_HPCrown()
    {
        HPCrown--;
        givenHPCrown++;
    }
    public void give_TrenchCoat()
    {
        TrenchCoat--;
        givenTrenchCoat++;
    }
    public void give_FakeID()
    {
        FakeID--;
        givenFakeID++;
    }
    public void give_ToyGun()
    {
        ToyGun--;
        givenToyGun++;
    }
    public void give_FacePaint()
    {
        FacePaint--;
        givenFacePaint++;
    }
    public void give_TeaSet()
    {
        TeaSet--;
        givenTeaSet++;
    }
    public void give_Saxaphone()
    {
        Saxaphone--;
        givenSaxaphone++;
    }
    public void give_EifelTower()
    {
        EifelTower--;
        givenEifelTower++;
    }
}