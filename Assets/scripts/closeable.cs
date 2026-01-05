using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeable : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            gameObject.SetActive(false);
        }
    }
}
