using UnityEngine;
using System.Collections;

public class MoveForward2D : MonoBehaviour 
{
	public float velocity;	// this is the speed that I'll move in the direction of my orientation

	// Use this for initialization
	void Start () 
	{
		Quaternion q = transform.rotation;

		Vector3 velocityRotated = q * new Vector3 (0, velocity, 0);

		GetComponent<Rigidbody2D> ().velocity = velocityRotated;
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
}
