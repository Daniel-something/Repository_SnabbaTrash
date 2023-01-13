using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public int trashPickUp = 1; //Bestämmer att skräpet inte plockats upp. - Daniel
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trashPickUp <= 0)
        {
            Destroy(gameObject); //Tar bort skräpet efter man plockat upp det. - Daniel
        }
    }
}
