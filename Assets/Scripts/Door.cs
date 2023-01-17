//Skriven av Daniel
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool doorOpen;
    // Start is called before the first frame update
    void Start()
    {
        doorOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (doorOpen == true)
        {
            Destroy(gameObject); //Öppnar dörren. - Daniel
        }
    }
}
