using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    private GameObject Canvas;
    private GameObject PP;
    public int FTEDictionary_PP;
    public int FTEDictionary_Num;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("HUD");
        PP = GameObject.Find("PP");
    }
    private void Update()
    {
        FTEDictionary_Num = Canvas.GetComponent<Stats>().dictionaries;
    }

    // Update is called once per frame
    public void Give_FTEDictionary()
    {
        if (FTEDictionary_Num > 0)
        {
            PP.GetComponent<PP>().IncreasePP(FTEDictionary_PP);
            Canvas.GetComponent<Stats>().give_dictionaries();
        }
    }
}
