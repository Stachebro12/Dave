using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien_select : MonoBehaviour
{
    public int alienNum = 1;
    public int alienTotal = 0;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public GameObject alien1;
    public GameObject alien2;
    public GameObject alien3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(leftKey))
        {
            if(alienNum > 1)
            {
                alienNum--;
            } else
            {
                alienNum = alienTotal;
            }
        }
        else if (Input.GetKeyDown(rightKey))
        {
            if (alienNum < alienTotal)
            {
                alienNum++;
            }
            else
            {
                alienNum = 1;
            }
        }
        if (alienNum == 1)
        {
            alien1.SetActive(true);
        }
        else 
        {
            alien1.SetActive(false); 
        }
        if (alienNum == 2)
        {
            alien2.SetActive(true);
        }
        else
        {
            alien2.SetActive(false);
        }
        if (alienNum == 3)
        {
            alien3.SetActive(true);
        }
        else
        {
            alien3.SetActive(false);
        }
    }
}
