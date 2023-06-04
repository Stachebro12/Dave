using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Choice_Manager : MonoBehaviour {
    private Conversation conversation;
    int[] jumps;

    public void Options(int jump1, int jump2, int jump3, Conversation thisConversation) {
        conversation = thisConversation;
        jumps = new int[] { jump1, jump2, jump3 }; //These are the numbers that must be jumped to.
        int intIndex = 0;
        GameObject[] buttons = new GameObject[] {transform.Find("Choice1").gameObject, transform.Find("Choice2").gameObject, transform.Find("Choice3").gameObject }; //The three buttons.
        buttons[0].GetComponent<Button>().onClick.AddListener(() => Execute(0)); //Adding listeners to each of the buttons. For some reason, we can't use a foreach loop.
        buttons[1].GetComponent<Button>().onClick.AddListener(() => Execute(1));
        buttons[2].GetComponent<Button>().onClick.AddListener(() => Execute(2));
        foreach (GameObject button in buttons) {
            button.transform.Find("Text").GetComponent<TMP_Text>().text = conversation.GetLine(jumps[intIndex] - 1).ToString(); //Changing the text to the option it represents.
            intIndex++;
        }
    }

    public void Execute(int jumpTo) { //This method is called from a listener on a button.
        conversation.Requeue(jumps[jumpTo], jumpTo);
        Destroy(gameObject);
    }
}