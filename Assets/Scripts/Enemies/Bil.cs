using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bil : MonoBehaviour
{
    Health health;

    void Start()
    {
        FindObjectOfType<Health>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            health.currentHealth -= collision.gameObject.GetComponent<Health>().health;
            health.currentHealth -= 1;
        }
    }
}
