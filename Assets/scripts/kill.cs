using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill : MonoBehaviour
{
    private GameObject canvas;
    private GameObject player;
    private int alienNum;

    public GameObject loadScreen;

    private void Awake()
    {
        canvas = GameObject.Find("HUD");
        player = GameObject.Find("Player");
        loadScreen = GameObject.Find("load screen");
    }

    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            if (canvas.GetComponent<Stats>().givenArmour == 0)
            {
                loadScreen.SetActive(true);
                alienNum = canvas.GetComponent<Stats>().alienNum;
                canvas.transform.Find("Panel").gameObject.SetActive(true);
                canvas.GetComponent<MainMenu>().ExtractNum();
                canvas.GetComponentInChildren<DayCounter>().timePassing();
                if (alienNum == 1)
                {
                    SceneManager.LoadScene("french_main");
                }
                else if (alienNum == 2)
                {
                    SceneManager.LoadScene("queen_main");
                }
                else if (alienNum == 3)
                {
                    SceneManager.LoadScene("empathetic_main");
                }
            }
            else
            {
                canvas.GetComponent<Stats>().Use_Armour();
            }
        }
    }
}
