using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class guard : MonoBehaviour
{
    public float stunTime;
    public bool stunned;
    public int bribeReq;
    public int bribeNum;
    // Start is called before the first frame update
    void Start()
    {
        stunned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(bribeNum >= bribeReq)
        {
            GetComponent<sight>().enabled = false;
        }
    }
    public void bribe()
    {
        bribeNum++;
    }
    public void kill()
    {
        Destroy(gameObject);
    }
    public void stunHit()
    {
        StartCoroutine("stun");
    }
    IEnumerator stun()
    {
        GetComponent<sight>().enabled = false;
        stunned = true;
        yield return new WaitForSeconds(stunTime);
        GetComponent<sight>().enabled = true;
        stunned = false;
    }
    public void stunKill()
    {
        if (stunned)
        {
            Destroy(gameObject);
        }
    }
}
