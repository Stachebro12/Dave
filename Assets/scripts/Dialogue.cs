using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string dave;
    [TextArea(3, 10)]
    public string[] sentences;
    [TextArea(1, 1)]
    public string[] instructions;
    public Sprite[] daves;
}