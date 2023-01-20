//Skriven av Daniel
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Upgrades : MonoBehaviour
{
    ShopManagerScript shopManager;
    Score score;
    PlayerMovement playerMovement;
    
    public int movementUpgrade; //Variabel som bestämmer hur mycket spelarens movement hastighet ska ökas när den uppgraderas. - Daniel
    public int inventoryUpgrade; //Variabel som bestämmer hur mycket spelarens inventory space ska ökas när den uppgraderas. - Daniel

    /*
    public int moveSpeedUpgrade1;
    public int moveSpeedUpgrade2;
    public int moveSpeedUpgrade3;
    public int backpackUpgrade1;
    public int backpackUpgrade2;
    public int backpackUpgrade3;
    */

    // Start is called before the first frame update
    void Start()
    {
        shopManager = FindObjectOfType<ShopManagerScript>();
        score = FindObjectOfType<Score>();
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (shopManager.item1Amount == 1)
        {
            playerMovement.walkSpeed = moveSpeedUpgrade1;
        }
        if (shopManager.item1Amount == 2)
        {
            playerMovement.walkSpeed = moveSpeedUpgrade2;
        }
        if (shopManager.item1Amount == 3)
        {
            playerMovement.walkSpeed = moveSpeedUpgrade3;
        }

        if (shopManager.item2Amount == 1)
        {
            score.trashMax = backpackUpgrade1;
        }
        if (shopManager.item2Amount == 2)
        {
            score.trashMax = backpackUpgrade2;
        }
        if (shopManager.item2Amount == 3)
        {
            score.trashMax = backpackUpgrade3;
        }
    }
        */
    }
}
