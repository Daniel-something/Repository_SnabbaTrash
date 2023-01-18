using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Skr�p;
    public bool spawning;
    public GameObject Skott;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateBonde());
        spawning = true;
    }

    IEnumerator CreateBonde() //Kallar p� SpawnBonde funktionen varje 1,5 sekunder -William
    {
        while (true)
        {
            SpawnBonde();
            yield return new WaitForSeconds(1.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnBonde() //Skapar en bonde slumpm�ssigt emellan de fyra v�ggarna -William
    {
        Instantiate(Skr�p);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
