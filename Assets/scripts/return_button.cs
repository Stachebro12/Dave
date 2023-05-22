using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class return_button : MonoBehaviour
{
    public AudioSource ButtonSound;
    private GameObject canvas;
    private int alienNum;

    private void Awake()
    {
        canvas = GameObject.Find("HUD");
    }

    public void Return_button()
    {
        //ButtonSound.Play();
        alienNum = canvas.GetComponent<Stats>().alienNum;
        canvas.transform.Find("Panel").gameObject.SetActive(true);
        canvas.GetComponent<MainMenu>().ExtractNum();
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
