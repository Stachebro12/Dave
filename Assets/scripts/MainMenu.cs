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
        SceneManager.LoadScene("french");
    }
    public void Alien2()
    {
        //ButtonSound.Play();
        SceneManager.LoadScene("queen");
    }
    public void Alien3()
    {
        //ButtonSound.Play();
        SceneManager.LoadScene("empathetic");
    }
}