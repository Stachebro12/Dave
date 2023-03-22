using UnityEngine;
using System.Collections;


public class InstantiateOnKey : MonoBehaviour 
{
	public KeyCode key;				// which key
	public Transform instantiate;	// causes what to be created?
	public float delayTime;			// what is the minimum time?


	private float timer = 0;

    // Update is called once per frame
    void Update () 
	{
		// if there's a delay between keypresses imposed, let the time run down
		if (timer > 0)
		{
			timer -= Time.deltaTime;
			return;
		}

		// ok, if there was a delay, it's over with, so we can detect another press
		if (Input.GetKeyDown (key))
		{
			Instantiate (instantiate, transform.position, transform.rotation);
			timer = delayTime;
		}
	}
}
