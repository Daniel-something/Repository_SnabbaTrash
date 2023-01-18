//Skriven av Daniel
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 4.5f;
    public Rigidbody2D rb;
    OpenShop shop;
    
    [HideInInspector]
    public Vector2 Movement;
    public Vector2 lastMovement;

    private void Start()
    {
        shop = FindObjectOfType<OpenShop>();
    }

    void Update()
    {   
            Movement.x = Input.GetAxisRaw("Horizontal"); //G�r att "Horizontal" knapparna f�r spelaren att g� i x-axeln. - Daniel
            Movement.y = Input.GetAxisRaw("Vertical"); //G�r att "Vertical" knapparna f�r spelaren att g� i y-axeln. - Daniel
        
        if (Movement.magnitude > 0)
        {
            lastMovement = Movement;
        }
    }

    private void FixedUpdate()
    {
            rb.MovePosition(rb.position + Movement * walkSpeed * Time.fixedDeltaTime); //Anv�nder alla v�rdena f�r att f� spelaren att f�rflyttas. - Daniel        
    }
}
