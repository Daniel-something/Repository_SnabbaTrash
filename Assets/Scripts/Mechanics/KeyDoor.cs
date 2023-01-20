//Skriven av Daniel
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyDoor : MonoBehaviour
{
    Score score;
    Door door;
    public Text info;
    public int trashbagAmount;
    public string infoText;
    void Start()
    {
        score = FindObjectOfType<Score>();
        door = FindObjectOfType<Door>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            info.text = infoText; //Visar informationen när spelaren går nära. - Daniel
        }
        else
        {
            info.text = null; //Tar bort texten när spelaren går därifrån. - Daniel
        }
        if (trashbagAmount == score.TrashBags) //Gör att dörren öppnas och texten försvinner om spelaren går nära med rätt mängd soppåsar. - Daniel
        {
            info.text = null;
            door.doorOpen = true; 
        }
    }
}