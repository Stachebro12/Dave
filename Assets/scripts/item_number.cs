using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_number : MonoBehaviour
{
    public int number;
    public int item;
    public Text Count;
    private GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("HUD");
    }

    // Update is called once per frame
    void Update()
    {
        if (item == 0)
        {
            Count.text = "" + canvas.GetComponent<Stats>().FTEDictionary;
        }
    }
}
