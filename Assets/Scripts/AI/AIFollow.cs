using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollow : MonoBehaviour
{

    public float speed;
    public float chaseDistance;

    private Transform target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    //Om AIn är nära dig, börja jaga.
    private void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < chaseDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    //Om AIn träffar dig
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            //hp--;
        }
    }
}