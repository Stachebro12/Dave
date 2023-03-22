using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key_Collect : MonoBehaviour
{
    public float keyNum = 0f;

    public void PickupKey()
    {
        keyNum += 1;
    }

    public void UseKey()
    {
        keyNum -= 1;
    }
}
