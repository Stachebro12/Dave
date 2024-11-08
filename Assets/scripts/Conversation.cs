using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Conversation : MonoBehaviour
{ //Use this with the Dialogue Manager prefab.
    public bool autoStart; //Check this checkbox if you want the dialogue to start when the scene is loaded.
    public float pauseTime; //The amount of time in seconds (make it a decimal) between characters being entered into the textbox.
    private float smallPause = 0.5f;
    private float bigPause = 1f;
    private bool isWaiting = false;
    private string currentLine;
    public Dialogue dialogue; //This draws from the Dialogue script.
    private Queue<string> lines; //The lines of text in the dialogue. Note that this is a queue.
    private Queue<Sprite> images;
    private string[] instructions; //A sequence of commands that tells the game how to behave. Write choice (## PP, ## PP, ## PP) to bring up a choice of 3 options,
                                   //and skip (##) to skip to a different line.
    private int instrucIndex = -1; //An indicator of which instruction to use.
    private bool started = false; //Whether or not the dialogue has started.
    private int[] ppValues = new int[] { 0, 0, 0 };
    private GameObject canvas; //Make sure there is a canvas in whatever scene you use this in.
    private Stats stats;
    private DayCounter dayCounter;
    private PP ppScript;
    private Conversation conversation; //A reference to this very script, which must be given to the Choice_Manager script.
    public GameObject textBox; //The Textbox object. Put this prefab into the field in the inspector. It is instantiated at runtime.
    public GameObject portrait; //The character portrait. Right now, changing to different character portraits is not possible.
    public GameObject choicePanel; //The menu that appears to offer the player a choice.
    public GameObject importantButton;
    private GameObject marker;
    private TMP_Text content; //The textbox that is modified through script;
    private GameObject thisDave;
    public int alien; //Right now we'll set this in the inspector. This will determine what scene we load when the alien is caught.
    public bool backToMenu = true; //This will return you to the menu if set to true.
    private bool isMain = false; //This variable determines whether the dialogue is for the main character or the Dave.
    private bool isDone = false;
    private bool mustChoose = false;
    private bool doSkip = false;

    void Awake() {
        canvas = GameObject.Find("HUD"); //Finds the canvas in the scene, before anything else.
        stats = canvas.GetComponent<Stats>();
        dayCounter = canvas.transform.Find("Day").GetComponent<DayCounter>();
        ppScript = canvas.transform.Find("PP").GetComponent<PP>();
        conversation = GetComponent<Conversation>();
    }

    void Start() {
        if (autoStart) {
            Begin();
        }
    }

    void Update() {
        if (started && Input.GetButtonDown("Submit")) {
            if (isDone && !mustChoose && !doSkip) {
                NextLine(); //This allows the player to advance to the next line with input. Going forward, we'd probably want this to fill in the textbox if it hasn't finished typing.
            }
            else {
                isDone = true;
                if (isWaiting) {
                    StopAllCoroutines();
                    StartCoroutine(TypeSentence(currentLine.Substring(content.text.Length + 1, (currentLine.Length - content.text.Length) - 1)));
                }
            }
            if (doSkip) {
                doSkip = false;
                Requeue(Convert.ToInt32(instructions[instrucIndex].Substring(6, 2)), 0);
            }
        }
    }

    public void Begin() {
        lines = new Queue<string>();
        lines.Clear();
        images = new Queue<Sprite>();
        images.Clear();
        foreach (string s in dialogue.sentences)
        {
            lines.Enqueue(s); //This loops though all of the lines in the array and appends them to the queue.
        }
        foreach (Sprite s in dialogue.daves)
        {
            images.Enqueue(s); //This loops though all of the lines in the array and appends them to the queue.
        }
        instructions = dialogue.instructions;
        started = true;
        thisDave = Instantiate(portrait, new Vector3(950, 400, 0), Quaternion.identity); //Instantiates the character. We will need to assign this object to a variable if we want to manipulate it.
        thisDave.transform.SetParent(canvas.transform);
        thisDave.transform.localScale = new Vector3(10f, 10f, 0);
        GameObject newprefab = Instantiate(textBox, new Vector3(950, 150, 0), Quaternion.identity); //Instantiates the textbox.
        newprefab.transform.SetParent(canvas.transform);
        content = newprefab.transform.Find("Content").GetComponent<TMP_Text>();
        marker = newprefab.transform.Find("Marker").gameObject;
        if (stats.dictionaries > 0) {
            GameObject dict = Instantiate(importantButton, new Vector3(1750, 850, 0), Quaternion.identity);
            dict.transform.SetParent(canvas.transform);
        }
        NextLine();
    }

    public void Requeue(int lineSkip, int changePP) { //This clears the queue and enqueues the dialogue array all over again from a certain point.
        ppScript.IncreasePP(ppValues[changePP]);
        lines.Clear();
        images.Clear();
        string[] newLines = dialogue.sentences.Skip(lineSkip).Take(dialogue.sentences.Length - lineSkip).ToArray();
        Sprite[] newImages = dialogue.daves.Skip(lineSkip).Take(dialogue.daves.Length - lineSkip).ToArray();
        foreach (string s in newLines) {
            lines.Enqueue(s); //This loops though all of the lines in the array and appends them to the queue.
        }
        foreach (Sprite s in newImages) {
            images.Enqueue(s); //This loops though all of the lines in the array and appends them to the queue.
        }
        instrucIndex = lineSkip - 1; //We also need to have the correct indicator of which instruction to execute.
        mustChoose = false;
        started = false;
        NextLine();
    }

    private void NextLine() {
        marker.SetActive(false);
        instrucIndex++;
        isMain = false;
        if (lines.Count == 0) {
            EndDialogue(alien, backToMenu);
            return;
        }
        Sprite newDave = images.Dequeue();
        if (newDave != null) {
            thisDave.GetComponent<Image>().sprite = newDave;
        }
        string line = lines.Dequeue(); //The Dequeue function will remove the next item from the queue and return it's value.
        if (line.Substring(0, 3) == "\\m ") { //Parses the stirng for '\m ' to determine if it is the main character speaking/thinking.
            line = line.Substring(3, line.Length - 3); //Make sure the dialogue is not less than 3 characters.
            isMain = true;
        }
        currentLine = line;
        content.text = ""; //Resets the text.
        content.color = Color.white; //Changes the character back to white for the Dave's dialogue. No if statement needed, it would do nothing.
        if (isMain) {
            content.color = Color.cyan; //Changes the color to cyan if it is the character speaking/thinking.
        }
        StopAllCoroutines(); //Stops writing the line. Otherwise, we could potentially have two lines typing at once.
        //Debug.Log("Falsifying isDone.");
        isDone = false;
        StartCoroutine(TypeSentence(line)); //Types the sentence gradually.
    }

    public void ShowChoices() {
        mustChoose = true; //This sets a variable that prevents the player from advancing the dialogue without choosing.
        GameObject newChoices = Instantiate(choicePanel, new Vector3(950, 550, 0), Quaternion.identity); //This instantiates the choice panel.
        newChoices.transform.SetParent(canvas.transform);
        Choice_Manager choiceManager = newChoices.GetComponent<Choice_Manager>();
        ppValues = new int[] { Convert.ToInt32(instructions[instrucIndex].Substring(11, 2)), Convert.ToInt32(instructions[instrucIndex].Substring(18, 2)), Convert.ToInt32(instructions[instrucIndex].Substring(25, 2)) };
        choiceManager.Options(Convert.ToInt32(instructions[instrucIndex].Substring(8, 2)), Convert.ToInt32(instructions[instrucIndex].Substring(15, 2)), Convert.ToInt32(instructions[instrucIndex].Substring(22, 2)), conversation);
        //You must input three numbers, one for each line that is an option. They must be 2 digit i.e. 04 instead of 4.
    }

    private void EndDialogue(int alienNum, bool doLoad) {
        Destroy(content.gameObject.transform.parent.gameObject);
        Destroy(thisDave);
        stats.dateUp();
        canvas.GetComponent<MainMenu>().ExtractNum();
        dayCounter.timePassing();
        if (GameObject.Find("Lose") != null) {
            if (alienNum == 1) {
                SceneManager.LoadScene("french lose");
            }
            else if (alienNum == 2) {
                SceneManager.LoadScene("queen lose");
            }
        }
        else {
            canvas.transform.Find("Panel").gameObject.SetActive(true);
            if (alienNum == 1) {
                SceneManager.LoadScene("french_Main");
            }
            else if (alienNum == 2) {
                SceneManager.LoadScene("queen_Main");
            }
            else if (alienNum == 3) {
                SceneManager.LoadScene("empathetic_Main");
            }
        }
    }

    IEnumerator TypeSentence(string sentece) {
        if (started == false) {
            yield return null;
            started = true;
        }
        foreach (char letter in sentece.ToCharArray()) {
            if (letter != '\\' && letter != '|') { //These characters are used for pauses. \ is a small pause, | is a big pause.
                content.text += letter;
            }
            float newTime;
            if (letter == '\\') {
                newTime = smallPause;
            }
            else if (letter == '|') {
                newTime = bigPause;
            }
            else {
                newTime = pauseTime;
            }
            if (!isDone) { //If the player inputs, we want to enter in the rest of the dialogue all at once.
                if (newTime > pauseTime) {
                    isWaiting = true;
                }
                yield return new WaitForSeconds(newTime);
                if (isWaiting) {
                    isWaiting = false;
                }
            }
        }
        isDone = true;
        if (instructions[instrucIndex].Length == 28) { //This detects if one of the instructions is meant to instantiate a choice menu.
            ShowChoices();
        }
        else {
            marker.SetActive(true);
            if (instructions[instrucIndex].Substring(0, 4) == "skip") { //This instruction is for skipping to another line in the sequence. This is impotant for dialogue trees.
                doSkip = true;
            }
        }
    }

    public IEnumerable GetLine(int specLine) { //This returns a specific line from the dialogue manager. It is used for the choice menu.
        return dialogue.sentences[specLine].Substring(3, dialogue.sentences[specLine].Length - 3).Replace("\\", "").Replace("|", "");
    }
}