using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int trashCollected;
    public int TrashBags;
    // Start is called before the first frame update
    void Start()
    {
        trashCollected = 0; //Variabel till m�ngden skr�p man plockat. - Daniel
        TrashBags = 0; //Variabel till m�ngden sopp�sar man plockat. - Daniel
    }

    // Update is called once per frame
    void Update()
    {

    }
}
