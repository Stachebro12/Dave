using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loading_for_parents : MonoBehaviour
{
    public GameObject LoadScreen;
    // Start is called before the first frame update
    public void loading ()
    {
        LoadScreen.SetActive (true);
    }
}
