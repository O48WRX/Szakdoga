using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameBaseClassLibrary.Actor.Abstracts;
using ActorClassLibrary.Abstracts;

public class PlayerMovementBehaviour : PlayerMovementAbstract
{
    public override void JumpIfCan()
    {
        if (Input.GetKey(KeyCode.W) && isGrounded && !isPlayerFalling())
        {
            Jump();
        }
    }

    private void Awake()
    {
        // Grab references from objects.
        Playerbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    //Runs every frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Playerbody.velocity = new Vector2(horizontalInput * speed,Playerbody.velocity.y);

        FlipPlayerSpriteTransform();

        JumpIfCan();

        PlayerSetFallBoolean();

        // Set animator parameters
        anim.SetBool("isRunning", horizontalInput != 0);
        anim.SetBool("isGrounded", isGrounded);
        anim.SetBool("isFalling", isFalling);
    }
}
