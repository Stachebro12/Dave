using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeable_Tute : MonoBehaviour
{
    public GameObject start;
    public GameObject player;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            start.SetActive(true);
            gameObject.SetActive(false);
            player.GetComponent<playerController>().enabled = true;
        }
    }
}
