using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Skräp;
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

    IEnumerator CreateBonde() //Kallar på SpawnBonde funktionen varje 8.5 sekunder
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
        //byt till inunitysphere spawn -JR
        //Instantiate(new GameObject(), transform.position + new Vector3(Random.Range(10, 10), Random.Range(-10,10),0), Quaternion.identity);
    }

    void SpawnBonde() 
    {
        Instantiate(Skräp,transform.position + new Vector3(Random.Range(-11, 11), Random.Range(-11, 11), 0), Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Destroy(collision.gameObject);
        }
    }
}
