using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Av Sebastian
*Kod för Inventory slots
* Läggs på Inventory objekten
*/
public class Slot : MonoBehaviour
{

    private Inventory inventory;

    public int i; //Vilken slot det är och var objekt kan då läggas in (0, 1, 2, 3)

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); //Hittar spelaren och hämtar Inventory koden
    }

    //Checkar om inventoryn är full. 
    private void Update()
    {
        if(transform.childCount <= 0)
        {
            inventory.isFull[i] = false;
        }
    }
}
