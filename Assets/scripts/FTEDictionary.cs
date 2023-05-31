using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FTEDictionary : MonoBehaviour
{
    private GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("HUD");
    }

    // Update is called once per frame
    void Update()
    {
        if(canvas.GetComponent<Stats>().FTEDictionary > 0)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
    public void Open_Dictionary()
    {

    }
}
