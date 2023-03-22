using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource ButtonSound;

    public void Menu()
    {
        //ButtonSound.Play();
        SceneManager.LoadScene("Main Menu");
    }

    public void Alien1()
    {
        //ButtonSound.Play();
        SceneManager.LoadScene("Alien 1 day 1");
    }
    public void Alien2()
    {
        //ButtonSound.Play();
        SceneManager.LoadScene("Alien 2 day 1");
    }
    public void Alien3()
    {
        //ButtonSound.Play();
        SceneManager.LoadScene("Alien 3 day 1");
    }
}