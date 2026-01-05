using UnityEngine;

public class Stealth_tutorial : MonoBehaviour
{
    public bool touching = false;

    public GameObject popup;
    public GameObject tute;
    public GameObject player;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            popup.SetActive(true);
            touching = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            popup.SetActive(false);
            touching = false;
        }
    }

    void Update()
    {
        if (touching)
        {
            if (Input.GetKeyUp(KeyCode.S))
            {
                Debug.Log("push");
                popup.SetActive(false);
                tute.SetActive(true);
                gameObject.SetActive(false);
                player.GetComponent<playerController>().enabled = false;
            }
        }
    }
}
