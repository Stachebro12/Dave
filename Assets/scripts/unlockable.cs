using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockable : MonoBehaviour
{
    private GameObject Canvas;
    public int checkpoint;
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("HUD");
    }

    // Update is called once per frame
    void Update()
    {
        if (checkpoint == 3)
        {
            if (Canvas.GetComponent<Stats>().checkpoint3 == true)
            {
                gameObject.SetActive(true);
                Debug.Log("on");

            }
            else
            {
                gameObject.SetActive(false);
                Debug.Log("off");
            }
        }
        if (checkpoint == 6)
        {
            if (Canvas.GetComponent<Stats>().checkpoint6 == true)
            {
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        if (checkpoint == 7)
        {
            if (Canvas.GetComponent<Stats>().checkpoint7 == true)
            {
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        if (checkpoint == 8)
        {
            if (Canvas.GetComponent<Stats>().checkpoint8 == true)
            {
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        if (checkpoint == 10)
        {
            if (Canvas.GetComponent<Stats>().checkpoint10 == true)
            {
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
}
