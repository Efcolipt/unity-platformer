using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    [SerializeField] private float speed = 2f;

    private int currentWaypointIdx = 0;

    // Update is called once per frame
    private void Update()
    { 
        if (waypoints.Length > 0) {
            if (Vector2.Distance(waypoints[currentWaypointIdx].transform.position, transform.position) < .1f) {
            currentWaypointIdx++;

            if (currentWaypointIdx >= waypoints.Length) {
                currentWaypointIdx = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIdx].transform.position, Time.deltaTime * speed);
        }
    }
}
