using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Av Sebastian

public class CameraScroll : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, transform.position.z); //Får Kameran att följa efter spelaren via player.position och sen respektive offset.
    }
}
