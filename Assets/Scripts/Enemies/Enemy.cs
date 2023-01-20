using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Skr�p;
    public bool spawning;
    public GameObject Skott;
    public Transform firePoint;
    public Health health;
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
            yield return new WaitForSeconds(8.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCube()
    {
        Instantiate(new GameObject(), transform.position + new Vector3(Random.Range(-500, 500), Random.Range(-500,500),0), Quaternion.identity);
    }

    void SpawnBonde() 
    {
        Instantiate(Skr�p,transform.position + new Vector3(Random.Range(-500, 500), Random.Range(-500, 500), 0), Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Destroy(collision.gameObject);
        }
    }
}
