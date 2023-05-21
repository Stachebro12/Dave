using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TEFinish : MonoBehaviour
{
    private GameObject stats;
    private GameObject canvas;
    public int alienNum;
    // Start is called before the first frame update
    void Start()
    {
        stats = GameObject.Find("Stats");
        canvas = GameObject.Find("HUD");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        stats.GetComponent<Stats>().TEWin();
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
}
