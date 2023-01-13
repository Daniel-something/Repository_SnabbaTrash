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
            netDirection = movement.Movement; //G�r netDirection till den senaste riktningen spelaren gick �t. - Daniel 
        }
        if (cooldownTime <= 0) //Kollar om n�tet �r p� cooldown. - Daniel
        {
            if (Input.GetKeyDown(netBag))
            {
                cooldownTime = startCooldownTime; //S�tter n�tet p� cooldown. - Daniel
                Collider2D[] trashInRange = Physics2D.OverlapBoxAll(netPos.position + netDirection * 2, new Vector2(netRangeX, netRangeY), trashCheck); //Sj�lva hitboxen f�r n�tet. netPos best�mmer att hitboxen hamnar p� gameObjectet netPos position, netDirection g�r att den hamnar framf�r spelaren �t riktningen spelaren senast gick i, netRange best�mmer storleken av hitboxen och trashCheck kollar p� objectets layer, om det har "Trash" plockar den up objektet. - Daniel
                for (int i = 0; i < trashInRange.Length; i++) //Kollar hur mycket trash som �r i hitboxen. - Daniel
                {
                    trashInRange[i].GetComponent<Trash>().trashPickUp =- 1; //G�r att trash plockas upp. - Daniel
                    //screenShake.shakeTime = 0.1f;
                    GetComponent<Score>().trashCollected += 1;
                    print(GetComponent<Score>().trashCollected);
                    //print("Recieved");
                    cooldownTime = startCooldownTime; //S�tter n�tet p� cooldown. - Daniel

                }
            }
        }
        if (cooldownTime > 0)
        {
            cooldownTime -= Time.deltaTime; //F�r cooldown timern att g� ner. - Daniel
        }

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(netPos.position + netDirection * 1, new Vector2(netRangeX, netRangeY)); //Ritar en outline p� n�tets hitbox s� att man kan se var den �r och hur stor den �r. - Daniel
    }
}
