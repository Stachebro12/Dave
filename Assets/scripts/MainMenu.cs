using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource ButtonSound;
    [HideInInspector]
    public int date;
    public bool isMain; //Set this to true if this object is on the main menu. Otherwise, it will look for a dateNum variable where there isn't one.
                        //It won't destroy the game, but it will throw an annoying error.
    public GameObject AreaSelect;
    public GameObject loadScreen;

    public void Awake() {
        if (!isMain) {
            ExtractNum();
        }
    }

    public void ExtractNum() {
        date = GetComponentInChildren<Stats>().dateNum; //We want to make sure to do this only when we need to, not every frame.
    }

    public void NewGame()
    {
        //ButtonSound.Play();
        SceneManager.LoadScene("menu");
    }

    public void Menu() {
        //ButtonSound.Play();
        SceneManager.LoadScene("Main Menu");
    }

    public void VisitAlien(string alien) {
        //ButtonSound.Play();
        SceneManager.LoadScene(alien); //Using string values, we can load the alien scene with one instruction, rather than an if branch.
        loadScreen.SetActive(true);

    }
    public void DoDate() {
        //ButtonSound.Play();
        if (Input.GetMouseButtonDown(0))
        {
            if (gameObject.GetComponent<Stats>().checkpoint4)
            {
                AreaSelect.SetActive(true);
            }
            else
            {
                loadScreen.SetActive(true);
                transform.Find("Panel").gameObject.SetActive(false); //We want to disable the alien menu when we enter the date.
                SceneManager.LoadScene(date);
            }
        }
    }
    public void Escape1()
    {
        //ButtonSound.Play();
        loadScreen.SetActive(true);
        SceneManager.LoadScene("tactical espionage French");
        transform.Find("Panel").gameObject.SetActive(false);
    }
    public void Escape2()
    {
        //ButtonSound.Play();
        loadScreen.SetActive(true);
        SceneManager.LoadScene("tactical espionage Queen");
        transform.Find("Panel").gameObject.SetActive(false);
    }
    public void Escape3()
    {
        //ButtonSound.Play();
        loadScreen.SetActive(true);
        SceneManager.LoadScene("tactical espionage Empathetic");
        transform.Find("Panel").gameObject.SetActive(false);
    }
    public void Shop()
    {
        //ButtonSound.Play();
        loadScreen.SetActive(true);
        SceneManager.LoadScene("Shop");
        transform.Find("Panel").gameObject.SetActive(false);
    }
    public void Gift1()
    {
        //ButtonSound.Play();
        loadScreen.SetActive(true);
        SceneManager.LoadScene("french Gift");
        transform.Find("Panel").gameObject.SetActive(false);
    }
    public void Gift2()
    {
        //ButtonSound.Play();
        loadScreen.SetActive(true);
        SceneManager.LoadScene("queen Gift");
        transform.Find("Panel").gameObject.SetActive(false);
    }
    public void Gift3()
    {
        //ButtonSound.Play();
        loadScreen.SetActive(true);
        SceneManager.LoadScene("empathetic Gift");
        transform.Find("Panel").gameObject.SetActive(false);
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void Quit()
    {
        Application.Quit();
    }
}