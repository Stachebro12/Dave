using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Malos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Indeed");
    }
    IEnumerator Indeed()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Main menu");
    }
}
