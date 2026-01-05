using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Change : MonoBehaviour {

    void Awake() {
        if (MainMenu.bgSprite) {
            GetComponent<SpriteRenderer>().sprite = MainMenu.bgSprite;
        }
    }
}