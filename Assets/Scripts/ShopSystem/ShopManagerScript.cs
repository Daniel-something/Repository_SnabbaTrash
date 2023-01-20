//Skriven av Sebastian, redigerad av Daniel
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[6,6];
    //public float money;
    public Text MoneyTxt;
    Score score;
    ButtonInfo button;
    PlayerMovement movement;
    Upgrades upgrades;
    public int item1Price;
    public int item2Price;
    public int item3Price;
    public int item1Amount;
    public int item2Amount;
    public int item3Amount;
    void Start()
    {
        score = FindObjectOfType<Score>();
        button = FindObjectOfType<ButtonInfo>();
        movement = FindObjectOfType<PlayerMovement>();
        upgrades = FindObjectOfType<Upgrades>();

        MoneyTxt.text = "Money: " + score.Money;//.ToString();

        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;

        //Price
        shopItems[2, 1] = item1Price;
        shopItems[2, 2] = item2Price;
        shopItems[2, 3] = item3Price;

        //Quantity
        shopItems[3, 1] = item1Amount;
        shopItems[3, 2] = item2Amount;
        shopItems[3, 3] = item3Amount;

        //Upgrade type
        shopItems[4, 1] = movement.walkSpeed;
        shopItems[4, 2] = score.trashMax;
        shopItems[4, 3] = 3;

        //Upgrade amount
        shopItems[5, 1] = upgrades.movementUpgrade;
        shopItems[5, 2] = upgrades.inventoryUpgrade;
        shopItems[5, 3] = 3;

    }

    //Kod f�r att k�pa objekt
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if(score.Money >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID]) //Du kan k�pa om du har r�d - Sebastian
        {
            score.Money -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID]; //tar bort pengar - Sebastian
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            shopItems[4, ButtonRef.GetComponent<ButtonInfo>().ItemID] += shopItems[5, ButtonRef.GetComponent<ButtonInfo>().ItemID]; //�kar variabeln som best�mmer spelarens abilities som walkSpeed och trashMax med v�rdet av Score scriptets motsvarande variabel som best�mmer hur mycket de ska uppgraderas. - Daniel
            MoneyTxt.text = "Money" + score.Money.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString(); //Updaterar string - Sebastian
            print(item1Amount);
            print(item2Amount);
        }
    }
    private void Update()
    {
        MoneyTxt.text = "Money: " + score.Money;
        movement.walkSpeed = shopItems[4, 1]; //Kollar att walkSpeed alltid �r desamma som shopItems[4, 1], vilket �r variabeln som f�rst f�r uppgraderingarna. - Daniel
        score.trashMax = shopItems[4, 2];//Kollar att trashMax alltid �r desamma som shopItems[4, 2], vilket �r variabeln som f�rst f�r uppgraderingarna. - Daniel
        //money = score.Money;
    }
}
