using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Sebastian
public class AIFollow : MonoBehaviour
{

    public float speed;
    public float chaseDistance;

    private Transform target;

    Health health;

    private void Start()
    {
        FindObjectOfType<Health>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    //Om AIn ?r n?ra dig, b?rja jaga.
    private void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < chaseDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    //Om AIn tr?ffar dig
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            health.health -= 1;

        }
    }
}