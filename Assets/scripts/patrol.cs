using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour
{
    public Transform[] waypoints;
    private int _currentWaypointIndex = 0;
    private float _speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<guard>().stunned == false)
        {
            Transform wp = waypoints[_currentWaypointIndex];
            if (Vector3.Distance(transform.position, wp.position) < 0.01f)
            {
                _currentWaypointIndex = (_currentWaypointIndex + 1) % waypoints.Length;
            }
            else
            {
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    wp.position,
                    _speed * Time.deltaTime);
                transform.LookAt(wp.position);
                // what direction do I want to look in?
                Vector3 delta = wp.position - transform.position;

                // if we're at the target position, don't rotate -- just keep facing current direction (and don't divide by 0)
                if (delta.x == 0 && delta.y == 0) return;

                // what is the rotation angle (around the Z axis) ; NB, -90 assumes sprite was drawn facing "UP" for an angle of 0
                float angle = Mathf.Rad2Deg * Mathf.Atan2(delta.y, delta.x) - 90.0f;

                // and set the angle
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);  // NB, that's forward in 3d space - z as 1
            }
        }
    }
}
