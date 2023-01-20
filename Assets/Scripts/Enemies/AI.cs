using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Sebastian
public class AI : MonoBehaviour
{
    public Transform[] waypoints; //lista f�r waypoints
    public int currentWaypointIndex = 0;
    public float speed;

    private float waitTime = 1f; //sekunder

    private void Start()
    {
        StartCoroutine(MovingToNextWaypoint());
    }

    //AIn �ker fr�n waypoint till waypoint. Om inom 0.01f, �k till n�sta waypoint, annars forts�tt.
    private IEnumerator MovingToNextWaypoint()
    {
        Transform wp = waypoints[currentWaypointIndex];

        //N�r �ver 0.01f, forts�tt �ka
        while (Vector3.Distance(transform.position, wp.position) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, wp.position, speed * Time.deltaTime);
            yield return null;
        }

        transform.position = wp.position;
        yield return new WaitForSeconds(waitTime); // N�r du har n�tt waypoint, v�nta 1 sekund innan du forts�tter
        currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length; //l�gger till 1, checkar waypoints och dividerar.

        StartCoroutine(MovingToNextWaypoint()); //All work and no play
    }
}
