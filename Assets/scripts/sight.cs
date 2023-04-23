using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sight : MonoBehaviour
{
    public int alienNum;

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, Vector2.up);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up);
            if (hit.collider != null)
            {
                Transform target = hit.transform;
                if (target.name == "Player")
                {
                if (alienNum == 1)
                { 
                    SceneManager.LoadScene("french");
                } else if (alienNum == 2)
                {
                    SceneManager.LoadScene("queen");
                } else if (alienNum == 3)
                {
                    SceneManager.LoadScene("empathetic");
                }
                }
            }
    }
}
