using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNext : MonoBehaviour {
    
    void Start() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //This loads the next scene. When we select an alien, we only want to visit the scene
                                                                              //with the UI once, and it immediately pushes us to the next scene where we can make
                                                                              //a selection. If the UI is on the scene we keep coming back to to make a selection,
                                                                              //it will be created everytime we load that scene, and the UIs will start piling up.
    }
}