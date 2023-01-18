using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[5,5];
    //public float money;
    public Text MoneyTxt;
    Score score;
    public int item1Price;
    public int item2Price;
    public int item3Price;
    public int item1Amount;
    public int item2Amount;
    public int item3Amount;
    void Start()
    {
        score = FindObjectOfType<Score>();

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

    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if(score.Money >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            score.Money -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            MoneyTxt.text = "Money" + score.Money.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();

        }
    }
    private void Update()
    {
        MoneyTxt.text = "Money: " + score.Money;
        //money = score.Money;
    }
}
