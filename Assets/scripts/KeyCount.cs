using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCount : MonoBehaviour
{
    public Text Keys;

    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        float keys = Player.GetComponent<Key_Collect>().keyNum;

        Keys.text = "Keys: " + keys;
    }
}
