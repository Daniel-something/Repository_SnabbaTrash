//Skriven av Daniel
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashbag : MonoBehaviour
{
    Score score;
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            score.TrashBags += 1;
            print("Trashbags: " + score.TrashBags);
            Destroy(gameObject); //Tar bort soppåsen efter man plockat upp den. - Daniel
        }
    }
}
