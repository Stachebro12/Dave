using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource ButtonSound;
    public int date;
    public GameObject stats;

    public void Update()
    {
        date = stats.GetComponentInChildren<Stats>().dateNum;
    }
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

    public void Date1()
    {
        //ButtonSound.Play();
        if(date == 0)
        {
            SceneManager.LoadScene("french date 1");
        } else if (date == 1)
        {
            SceneManager.LoadScene("french date 2");
        } else if (date == 2)
        {
            SceneManager.LoadScene("french date 3");
        } else if (date == 3)
        {
            SceneManager.LoadScene("french date 4");
        } else if (date == 4)
        {
            SceneManager.LoadScene("french date 5");
        } else if (date == 5)
        {
            SceneManager.LoadScene("french date 6");
        } else if (date == 6)
        {
            SceneManager.LoadScene("french date 7");
        }
    }
    public void Date2()
    {
        //ButtonSound.Play();
        if (date == 0)
        {
            SceneManager.LoadScene("queen date 1");
        }
        else if (date == 1)
        {
            SceneManager.LoadScene("queen date 2");
        }
        else if (date == 2)
        {
            SceneManager.LoadScene("queen date 3");
        }
        else if (date == 3)
        {
            SceneManager.LoadScene("queen date 4");
        }
        else if (date == 4)
        {
            SceneManager.LoadScene("queen date 5");
        }
        else if (date == 5)
        {
            SceneManager.LoadScene("queen date 6");
        }
        else if (date == 6)
        {
            SceneManager.LoadScene("queen date 7");
        }
    }
    public void Date3()
    {
        //ButtonSound.Play();
        if (date == 0)
        {
            SceneManager.LoadScene("empathetic date 1");
        }
        else if (date == 1)
        {
            SceneManager.LoadScene("empathetic date 2");
        }
        else if (date == 2)
        {
            SceneManager.LoadScene("empathetic date 3");
        }
        else if (date == 3)
        {
            SceneManager.LoadScene("empathetic date 4");
        }
        else if (date == 4)
        {
            SceneManager.LoadScene("empathetic date 5");
        }
        else if (date == 5)
        {
            SceneManager.LoadScene("empathetic date 6");
        }
        else if (date == 6)
        {
            SceneManager.LoadScene("empathetic date 7");
        }
    }
    public void Escape1()
    {
        //ButtonSound.Play();
        SceneManager.LoadScene("tactical espionage French");
    }
    public void Escape2()
    {
        //ButtonSound.Play();
        SceneManager.LoadScene("tactical espionage Queen");
    }
    public void Escape3()
    {
        //ButtonSound.Play();
        SceneManager.LoadScene("tactical espionage Empathetic");
    }

}