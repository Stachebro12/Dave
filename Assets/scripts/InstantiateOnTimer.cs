using UnityEngine;
using System.Collections;


public class InstantiateOnTimer : MonoBehaviour 
{
	public Transform instantiate;	// causes what to be created?

	public float delayMin;			// initial waiting period
	public float delayMax;			// 
	public float repeatMin;			// waiting period to repeat
	public float repeatMax;			// 


	private float timer = 0;


    void Start()
	{
        enabled = false;
        // set up the initial delay
        timer = Random.Range (delayMin, delayMax);
    }

    void OnBecameVisible()
    {
        enabled = true;
    }

	private void OnBecameInvisible()
	{
		enabled = false;
	}

	void Update () 
	{
		// wait for the time to expire
		if (timer > 0)
		{
			timer -= Time.deltaTime;
			return;
		}

		// ok, time to make me something
		Instantiate (instantiate, transform.position, transform.rotation);

        // reset the timer
        timer = Random.Range (repeatMin, repeatMax);
	}
}
