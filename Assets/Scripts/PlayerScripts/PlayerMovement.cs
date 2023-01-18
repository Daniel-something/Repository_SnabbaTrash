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
            Movement.x = Input.GetAxisRaw("Horizontal"); //Gör att "Horizontal" knapparna får spelaren att gå i x-axeln. - Daniel
            Movement.y = Input.GetAxisRaw("Vertical"); //Gör att "Vertical" knapparna får spelaren att gå i y-axeln. - Daniel
        
        if (Movement.magnitude > 0)
        {
            lastMovement = Movement;
        }
    }

    private void FixedUpdate()
    {
            rb.MovePosition(rb.position + Movement * walkSpeed * Time.fixedDeltaTime); //Använder alla värdena för att få spelaren att förflyttas. - Daniel        
    }
}
