using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlockable_item : MonoBehaviour
{
    public int batchNum;
    public GameObject Canvas;
    void Start()
    {
        Canvas = GameObject.Find("HUD");
        gameObject.SetActive(false);
        if (batchNum == 1)
        {
            if (Canvas.GetComponent<Stats>().checkpoint3)
            {
                gameObject.SetActive(true);
            }
        }
        if (batchNum == 2)
        {
            if (Canvas.GetComponent<Stats>().checkpoint7)
            {
                gameObject.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
