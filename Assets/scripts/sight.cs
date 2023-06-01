using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sight : MonoBehaviour
{
    private int alienNum;
    private GameObject canvas;

    private void Awake()
    {
        canvas = GameObject.Find("HUD");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.up);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
            if (hit.collider != null)
            {
            Transform target = hit.transform;
            Debug.Log(target.name);
                if (target.name == "Player")
                {
                alienNum = canvas.GetComponent<Stats>().alienNum;
                canvas.transform.Find("Panel").gameObject.SetActive(true);
                canvas.GetComponent<MainMenu>().ExtractNum();
                canvas.GetComponentInChildren<DayCounter>().timePassing();
                if (alienNum == 1)
                { 
                    SceneManager.LoadScene("french_main");
                } else if (alienNum == 2)
                {
                    SceneManager.LoadScene("queen_main");
                } else if (alienNum == 3)
                {
                    SceneManager.LoadScene("empathetic_main");
                }
                }
            }
    }
}
