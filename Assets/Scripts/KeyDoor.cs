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
            info.text = infoText; //Visar informationen n�r spelaren g�r n�ra. - Daniel
        }
        else
        {
            info.text = null; //Tar bort texten n�r spelaren g�r d�rifr�n. - Daniel
        }
        if (trashbagAmount == score.TrashBags) //G�r att d�rren �ppnas och texten f�rsvinner om spelaren g�r n�ra med r�tt m�ngd sopp�sar. - Daniel
        {
            info.text = null;
            door.doorOpen = true; 
        }
    }
}