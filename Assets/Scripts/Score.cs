//Skriven av Daniel
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int trashCollected; //Variabel till m�ngden skr�p man plockat. - Daniel
    public int trashMax; //Variabel till m�ngden skr�p man kan plocka. - Daniel
    public int TrashBags; //Variabel till m�ngden sopp�sar man plockat. - Daniel
    public int Money; //Variabel till m�ngden pengar man har. - Daniel
    public int moneyCollected; //Variabel till m�ngden pengar man tj�nat men inte tagit ut. - Daniel

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
