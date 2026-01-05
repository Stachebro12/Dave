using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    private GameObject Canvas;
    private GameObject PP;
    public int FTEDictionary_PP;
    public int HPCrown_PP;
    public int TrenchCoat_PP;
    public int FakeID_PP;
    public int ToyGun_PP;
    public int FacePaint_PP;
    public int TeaSet_PP;
    public int Saxaphone_PP;
    public int EifelTower_PP;
    public int Pillow_PP;

    public int FTEDictionary_Num;
    public int HPCrown_Num;
    public int TrenchCoat_Num;
    public int FakeID_Num;
    public int ToyGun_Num;
    public int FacePaint_Num;
    public int TeaSet_Num;
    public int Saxaphone_Num;
    public int EifelTower_Num;
    public int Pillow_Num;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("HUD");
        PP = GameObject.Find("PP");
    }

    // Update is called once per frame
    public void Give_FTEDictionary()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FTEDictionary_Num = Canvas.GetComponent<Stats>().dictionaries;
            if (FTEDictionary_Num > 0)
            {
                PP.GetComponent<PP>().IncreasePP(FTEDictionary_PP);
                Canvas.GetComponent<Stats>().give_dictionaries();
            }
        }
    }
    public void Give_HPCrown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HPCrown_Num = Canvas.GetComponent<Stats>().HPCrown;
            if (HPCrown_Num > 0)
            {
                PP.GetComponent<PP>().IncreasePP(HPCrown_PP);
                Canvas.GetComponent<Stats>().give_HPCrown();
            }
        }
    }
    public void Give_TrenchCoat()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TrenchCoat_Num = Canvas.GetComponent<Stats>().TrenchCoat;
            if (TrenchCoat_Num > 0)
            {
                PP.GetComponent<PP>().IncreasePP(TrenchCoat_PP);
                Canvas.GetComponent<Stats>().give_TrenchCoat();
            }
        }
    }
    public void Give_FakeID()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FakeID_Num = Canvas.GetComponent<Stats>().FakeID;
            if (FakeID_Num > 0)
            {
                PP.GetComponent<PP>().IncreasePP(FakeID_PP);
                Canvas.GetComponent<Stats>().give_FakeID();
            }
        }
    }
    public void Give_ToyGun()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ToyGun_Num = Canvas.GetComponent<Stats>().ToyGun;
            if (ToyGun_Num > 0)
            {
                PP.GetComponent<PP>().IncreasePP(ToyGun_PP);
                Canvas.GetComponent<Stats>().give_ToyGun();
            }
        }
    }
    public void Give_FacePaint()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FacePaint_Num = Canvas.GetComponent<Stats>().FacePaint;
            if (FacePaint_Num > 0)
            {
                PP.GetComponent<PP>().IncreasePP(FacePaint_PP);
                Canvas.GetComponent<Stats>().give_FacePaint();
            }
        }
    }
    public void Give_TeaSet()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TeaSet_Num = Canvas.GetComponent<Stats>().TeaSet;
            if (TeaSet_Num > 0)
            {
                PP.GetComponent<PP>().IncreasePP(TeaSet_PP);
                Canvas.GetComponent<Stats>().give_TeaSet();
            }
        }
    }
    public void Give_Saxaphone()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Saxaphone_Num = Canvas.GetComponent<Stats>().Saxaphone;
            if (Saxaphone_Num > 0)
            {
                PP.GetComponent<PP>().IncreasePP(Saxaphone_PP);
                Canvas.GetComponent<Stats>().give_Saxaphone();
            }
        }
    }
    public void Give_EifelTower()
    {
        if (Input.GetMouseButtonDown(0))
        {
            EifelTower_Num = Canvas.GetComponent<Stats>().EifelTower;
            if (EifelTower_Num > 0)
            {
                PP.GetComponent<PP>().IncreasePP(EifelTower_PP);
                Canvas.GetComponent<Stats>().give_EifelTower();
            }
        }
    }
    public void Give_Pillow()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Pillow_Num = Canvas.GetComponent<Stats>().Pillow;
            if (Pillow_Num > 0)
            {
                PP.GetComponent<PP>().IncreasePP(Pillow_PP);
                Canvas.GetComponent<Stats>().give_Pillow();
            }
        }
    }
}
