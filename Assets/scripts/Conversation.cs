using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Conversation : MonoBehaviour { //Use this with the Dialogue Manager prefab.
    public bool autoStart; //Check this checkbox if you want the dialogue to start when the scene is loaded.
    public float pauseTime; //The amount of time in seconds (make it a decimal) between characters being entered into the textbox.
    public Dialogue dialogue; //This draws from the Dialogue script.
    private Queue<string> lines; //The lines of text in the dialogue. Note that this is a queue.
    private bool started = false; //Whether or not the dialogue has started
    private GameObject canvas; //Make sure there is a canvas in whatever scene you use this in.
    public GameObject textBox; //The Textbox object. Put this prefab into the field in the inspector. It is instantiated at runtime.
    public GameObject portrait; //The character portrait. Right now, changing to different character portraits is not possible.
    private TMP_Text content; //The textbox that is modified through script.

    void Awake() {
        canvas = GameObject.Find("Canvas"); //Finds the canvas in the scene, before anything else.
    }

    void Start() {
        if (autoStart) {
            Begin();
        }
    }

    void Update() {
        if (started && Input.GetButtonDown("Submit")) {
            NextLine(); //This allows the player to advance to the next line with input. Going forward, we'd probably want this to fill in the textbox if it hasn't finished typing.
        }
    }

    public void Begin() {
        lines = new Queue<string>();
        lines.Clear();
        foreach (string s in dialogue.sentences) {
            lines.Enqueue(s); //This loops though all of the lines in the array and appends them to the queue.
        }
        started = true;
        GameObject newprefab = Instantiate(textBox, new Vector3(950, 150, 0), Quaternion.identity); //Instantiates the textbox.
        newprefab.transform.SetParent(canvas.transform);
        content = newprefab.transform.Find("Content").GetComponent<TMP_Text>();
        Instantiate(portrait, new Vector3(0, 0, 0), Quaternion.identity); //Instantiates the character. We will need to assign this object to a variable if we want to manipulate it.
        NextLine();
    }

    private void NextLine() {
        if (lines.Count == 0) {
            EndDialogue();
            return;
        }
        string line = lines.Dequeue(); //The Dequeue function will remove the next item from the queue and return it's value.
        content.text = ""; //Resets the text.
        StopAllCoroutines(); //Stops writing the line. Otherwise, we could potentially have two lines typing at once.
        StartCoroutine(TypeSentence(line)); //Types the sentence gradually.
    }

    private void EndDialogue() {
        Debug.Log("End of conversation."); //Ends the dialogue. Doesn't do anything right now, but does prevent the game from throwing an error.
    }

    IEnumerator TypeSentence(string sentece) {
        foreach (char letter in sentece.ToCharArray())
        {
            content.text += letter;
            yield return new WaitForSeconds(pauseTime);
        }
    }
}