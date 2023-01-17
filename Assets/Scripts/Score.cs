//Skriven av Daniel
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int trashCollected; //Variabel till mängden skräp man plockat. - Daniel
    public int trashMax; //Variabel till mängden skräp man kan plocka. - Daniel
    public int TrashBags; //Variabel till mängden soppåsar man plockat. - Daniel
    public int Money; //Variabel till mängden pengar man har. - Daniel
    public int moneyCollected; //Variabel till mängden pengar man tjänat men inte tagit ut. - Daniel

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trashCollected > trashMax)
        {
            trashCollected = trashMax;
        }
    }
}
