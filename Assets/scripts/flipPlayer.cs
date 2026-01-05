using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipPlayer : MonoBehaviour
{
    private bool isRight = true;

    private SpriteRenderer Jsprite;

    public KeyCode leftKey;
    public KeyCode rightKey;
    private void Awake()
    {
        Jsprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (Input.GetKey(leftKey))
        {
            if (isRight)
            {
                Jsprite.flipX = true;
                isRight = false;
            }
        } else if (Input.GetKey(rightKey))
        {
            if (!isRight)
            {
                Jsprite.flipX = false;
                isRight = true;
            }
        }
    }
}
