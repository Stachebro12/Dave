using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill : MonoBehaviour
{
    private GameObject canvas;
    private GameObject player;
    public int alienNum;

    private void Awake()
    {
        canvas = GameObject.Find("HUD");
        player = GameObject.Find("Player");
    }

    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject == player)
        {
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
}
