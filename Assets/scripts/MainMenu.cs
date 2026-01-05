using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using static MainMenu;

public class MainMenu : MonoBehaviour {
    public AudioSource ButtonSound;
    [HideInInspector]
    public int date;
    public bool isMain; //Set this to true if this object is on the main menu. Otherwise, it will look for a dateNum variable where there isn't one.
                        //It won't destroy the game, but it will throw an annoying error.
    public GameObject AreaSelect;
    public GameObject loadScreen;
    public static Sprite bgSprite;

    [System.Serializable]
    public struct Pair<K, V> {
        public K key;
        [TextArea(3, 10)]
        public V value;
    }

    public List<Pair<Sprite, string>> bgComments = new List<Pair<Sprite, string>>();

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
        //I removed the check of Input.GetMouseButtonDown(0). Maybe it's there for a reason, but I can't see it right now.
        if (gameObject.GetComponent<Stats>().checkpoint4) {
            AreaSelect.SetActive(true);
        }
        else {
            StartDate(bgSprite);
        }
    }

    public void StartDate(Sprite passImage) {
        bgSprite = passImage;
        loadScreen.SetActive(true);
        transform.Find("Panel").gameObject.SetActive(false); //We want to disable the alien menu when we enter the date.
        transform.Find("Site Select").gameObject.SetActive(false);
        SceneManager.LoadScene(date);
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