using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Sebastian
public class AI : MonoBehaviour
{
    public Transform[] waypoints; //lista för waypoints
    public int currentWaypointIndex = 0;
    public float speed;

    private float waitTime = 1f; //sekunder

    private void Start()
    {
        StartCoroutine(MovingToNextWaypoint());
    }

    //AIn åker från waypoint till waypoint. Om inom 0.01f, åk till nästa waypoint, annars fortsätt.
    private IEnumerator MovingToNextWaypoint()
    {
        Transform wp = waypoints[currentWaypointIndex];

        //När över 0.01f, fortsätt åka
        while (Vector3.Distance(transform.position, wp.position) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, wp.position, speed * Time.deltaTime);
            yield return null;
        }

        transform.position = wp.position;
        yield return new WaitForSeconds(waitTime); // När du har nått waypoint, vänta 1 sekund innan du fortsätter
        currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length; //lägger till 1, checkar waypoints och dividerar.

        StartCoroutine(MovingToNextWaypoint()); //All work and no play
    }
}
