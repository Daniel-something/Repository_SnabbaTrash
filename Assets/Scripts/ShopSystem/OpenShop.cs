//Skriven av Sebastian, redigerad av Daniel
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop : MonoBehaviour
{
    Score score;
    public bool ShopMenuOpen;
    public GameObject ShopMenuUI;

    private void Start()
    {
        score = FindObjectOfType<Score>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //if (Input.GetKeyDown(KeyCode.E))
            //{
            ShopMenuUI.SetActive(true);
            score.Money += score.moneyCollected;
            score.moneyCollected = 0;
            score.trashCollected = 0;
            ShopMenuOpen = true;
            //}
        }
        else
        {
            ShopMenuUI.SetActive(false);
            ShopMenuOpen = false;
        }
    }
    
    void Update()
    {
        if (ShopMenuOpen = true && Input.GetKeyDown(KeyCode.Escape))
        {
            ShopMenuUI.SetActive(false);
            ShopMenuOpen = false;
        }
    }
}
