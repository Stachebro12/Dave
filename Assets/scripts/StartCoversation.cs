using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCoversation : MonoBehaviour {
    
    void OnCollisionEnter2D(Collision2D other) {
        if (other.collider.tag == "Player") {
            Destroy(other.gameObject);
            gameObject.GetComponent<Conversation>().Begin();
        }
    }
}