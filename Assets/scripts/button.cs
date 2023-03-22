using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject block;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        block.SetActive(false);
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        block.SetActive(true);
    }
}
