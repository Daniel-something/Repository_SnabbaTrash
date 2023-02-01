using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    Animator animator;
    SpriteRenderer sprite;

    PlayerMovement movement;
    Net net;

    public float time;
    public float downTime;
    // Start is called before the first frame update
    void Start()
    {
        animator = FindObjectOfType<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        movement = FindObjectOfType<PlayerMovement>();
        net = FindObjectOfType<Net>();
        time = downTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(movement.lastMovement.x == 1)
        {
            sprite.flipX = true;
        }

        if (movement.lastMovement.x == -1)
        {
            sprite.flipX = false;
        }

        if (movement.enabled == false)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                movement.enabled = true;
                time = downTime;
            }
        }

        if (!Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetFloat("SpeedX", movement.Movement.x);
            animator.SetFloat("SpeedY", movement.Movement.y);
        }


        if (Input.GetKeyDown(KeyCode.Space) && movement.lastMovement.y > 0.1f)
        {
            movement.enabled = false;
            animator.SetTrigger("UpNet");
        }

        else if (Input.GetKeyDown(KeyCode.Space) && movement.lastMovement.y < -0.1f)
        {
            movement.enabled = false;
            animator.SetTrigger("DownNet");
        }

    }
}
