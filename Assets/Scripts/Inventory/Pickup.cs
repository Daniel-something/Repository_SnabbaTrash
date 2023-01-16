using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Av Sebastian
*Kod för att ta upp saker
* Läggs på föremålet man vill ta upp, mer info för att skapa item finns på HealthItem koden
*/
public class Pickup : MonoBehaviour
{

    private Inventory inventory;
    public GameObject itemButton;

    public AudioClip Fanfare2;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); //Hitta med tag "Player"
    }

    //Om ett objekt kolliderar med "Player" hamnar den i inventoryn. Om inventoryn är full tas den inte upp.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++) //ser storleken i inventory
            {
                if(inventory.isFull[i] == false)
                {
                    //föremål kan läggas till inventory
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false); //lägger in objekt i inventoryn
                    Camera.main.GetComponent<AudioSource>().PlayOneShot(Fanfare2); //Aktiverar ljudeffekt
                    Destroy(gameObject); //tar bort den från scenen
                    break;
                }
            }
        }
    }
}
