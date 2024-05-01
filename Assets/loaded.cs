using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loaded : MonoBehaviour
{
    public GameObject loadScreen;
    // Start is called before the first frame update
    void Start()
    {
        loadScreen = GameObject.Find("load screen");
        loadScreen.SetActive(false);
    }
}
