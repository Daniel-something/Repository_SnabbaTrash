using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Net : MonoBehaviour
{
    
    public KeyCode netBag;
    public float cooldownTime;
    public float startCooldownTime;
    public Transform netPos;
    public float netRangeX;
    public float netRangeY;
    public int netCapture;
    public LayerMask trashCheck;
    PlayerMovement movement;
    Vector3 netDirection;

    private void Start()
    {
        movement = GetComponent<PlayerMovement>();
    }

    void LateUpdate()
    {
        if (movement.Movement.magnitude > 0)
        {
            netDirection = movement.Movement; //Gör netDirection till den senaste riktningen spelaren gick åt. - Daniel 
        }
        if (cooldownTime <= 0) //Kollar om nätet är på cooldown. - Daniel
        {
            if (Input.GetKeyDown(netBag))
            {
                cooldownTime = startCooldownTime; //Sätter nätet på cooldown. - Daniel
                Collider2D[] trashInRange = Physics2D.OverlapBoxAll(netPos.position + netDirection * 2, new Vector2(netRangeX, netRangeY), trashCheck); //Själva hitboxen för nätet. netPos bestämmer att hitboxen hamnar på gameObjectet netPos position, netDirection gör att den hamnar framför spelaren åt riktningen spelaren senast gick i, netRange bestämmer storleken av hitboxen och trashCheck kollar på objectets layer, om det har "Trash" plockar den up objektet. - Daniel
                for (int i = 0; i < trashInRange.Length; i++) //Kollar hur mycket trash som är i hitboxen. - Daniel
                {
                    trashInRange[i].GetComponent<Trash>().trashPickUp =- 1; //Gör att trash plockas upp. - Daniel
                    //screenShake.shakeTime = 0.1f;
                    GetComponent<Score>().trashCollected += 1;
                    print(GetComponent<Score>().trashCollected);
                    //print("Recieved");
                    cooldownTime = startCooldownTime; //Sätter nätet på cooldown. - Daniel

                }
            }
        }
        if (cooldownTime > 0)
        {
            cooldownTime -= Time.deltaTime; //Får cooldown timern att gå ner. - Daniel
        }

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(netPos.position + netDirection * 1, new Vector2(netRangeX, netRangeY)); //Ritar en outline på nätets hitbox så att man kan se var den är och hur stor den är. - Daniel
    }
}
