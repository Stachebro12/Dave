using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Text Health;

    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        float health1 = Player.GetComponent<PlayerHealth>().health;
        float maxHealth1 = Player.GetComponent<PlayerHealth>().maxHealth;

        Health.text = "Health: " + health1 + "/" + maxHealth1;
    }
}
