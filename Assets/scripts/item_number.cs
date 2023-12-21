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
            Count.text = "" + canvas.GetComponent<Stats>().dictionaries;
        }
        if (item == 1)
        {
            Count.text = "" + canvas.GetComponent<Stats>().HPCrown;
        }
        if (item == 2)
        {
            Count.text = "" + canvas.GetComponent<Stats>().TrenchCoat;
        }
        if (item == 3)
        {
            Count.text = "" + canvas.GetComponent<Stats>().FakeID;
        }
        if (item == 4)
        {
            Count.text = "" + canvas.GetComponent<Stats>().ToyGun;
        }
        if (item == 5)
        {
            Count.text = "" + canvas.GetComponent<Stats>().FacePaint;
        }
        if (item == 6)
        {
            Count.text = "" + canvas.GetComponent<Stats>().TeaSet;
        }
        if (item == 7)
        {
            Count.text = "" + canvas.GetComponent<Stats>().Saxaphone;
        }
        if (item == 8)
        {
            Count.text = "" + canvas.GetComponent<Stats>().EifelTower;
        }
    }
}
