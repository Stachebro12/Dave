using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DayCounter : MonoBehaviour
{
    public int day = 1;
    public Text DayText;
    public GameObject shop;
    public GameObject gift;
    public float PPRequirement;

    private GameObject canvas;
    private float PP;
    private bool TE;
    private bool checkpoint_1;
    private int alienNum;

    void Start()
    {
        canvas = GameObject.Find("HUD");
    }

    public void timePassing()
    {
        day++;
    }
    void Update()
    {
        PP = canvas.GetComponentInChildren<PP>().ppMax;
        TE = canvas.GetComponent<Stats>().TEWon;
        alienNum = canvas.GetComponent<Stats>().alienNum;
        checkpoint_1 = canvas.GetComponent<Stats>().checkpoint1;
        if (day == 1)
        {
            DayText.text = "Day 1";
        } 
        else if (day == 2)
        {
            DayText.text = "Night 1";
        }
        else if (day == 3)
        {
            DayText.text = "Day 2";
        }
        else if (day == 4)
        {
            DayText.text = "Night 2";
        }
        else if (day == 5)
        {
            DayText.text = "Day 3";
        }
        else if (day == 6)
        {
            DayText.text = "Night 3";
        }
        else if (day == 7)
        {
            DayText.text = "Day 4";
        }
        else if (day == 8)
        {
            DayText.text = "Night 4";
        }
        else if (day == 9)
        {
            DayText.text = "Day 5";
        }
        else if (day == 10)
        {
            DayText.text = "Night 5";
        }
        else if (day == 11)
        {
            DayText.text = "Day 6";
        }
        else if (day == 12)
        {
            DayText.text = "Night 6";
        }
        else if (day == 13)
        {
            DayText.text = "Day 7";
        }
        else if (day == 14)
        {
            DayText.text = "Night 7";
        }
        else if (TE == false)
        {
            if (alienNum == 1)
            {
                SceneManager.LoadScene("french trapped");
            }
            else if (alienNum == 2)
            {
                SceneManager.LoadScene("queen trapped");
            }
            else if (alienNum == 3)
            {
                SceneManager.LoadScene("empathetic trapped");
            }
        }
        else if (PP < PPRequirement)
        {
            if (alienNum == 1)
            {
                SceneManager.LoadScene("french flee");
            }
            else if (alienNum == 2)
            {
                SceneManager.LoadScene("queen flee");
            }
            else if (alienNum == 3)
            {
                SceneManager.LoadScene("empathetic flee");
            }
        }
        else
        {
            if (alienNum == 1)
            {
                SceneManager.LoadScene("french win");
            }
            else if (alienNum == 2)
            {
                SceneManager.LoadScene("queen win");
            }
            else if (alienNum == 3)
            {
                SceneManager.LoadScene("empathetic win");
            }
        }
        if (day % 2 == 0)
        {
            if(checkpoint_1 == true)
            {
                gift.SetActive(true);
            }
            shop.SetActive(false);
        }
        else
        {
            gift.SetActive(false);
            shop.SetActive(true);
        }
    }
}
