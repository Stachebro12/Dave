using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_trigger : MonoBehaviour
{
    public GameObject trap;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        trap.SetActive(true);
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        trap.SetActive(false);
    }
}
