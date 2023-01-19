//Skriven av Daniel
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    Score score;
    public Text trashText;
    public Text trashbagText;
    public Text moneyText;
    public Text worthText;
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        trashText.text = "Trash: " + score.trashCollected + "/" + score.trashMax;
        trashbagText.text = "Trashbags: " + score.TrashBags;
        moneyText.text = "Money: " + score.Money;
        worthText.text = "Money Earned: " + score.moneyCollected;
    }
}
