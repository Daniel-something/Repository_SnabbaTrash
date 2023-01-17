using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bil : MonoBehaviour
{
    Health health;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Health>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            health.health -= 1;
        }
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
