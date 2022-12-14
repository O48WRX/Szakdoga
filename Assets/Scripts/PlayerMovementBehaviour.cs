using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D Playerbody;
    private Animator anim;

    private float playerScaleX = 10;
    private float negPlayerScaleX = -10;
    private bool isGrounded;

    private void Awake()
    {
        // Grab references from objects.
        Playerbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    //Runs every frame
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Playerbody.velocity = new Vector2(horizontalInput * speed,Playerbody.velocity.y);

        // Flip player sprite transform
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(playerScaleX, 10, 10);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(negPlayerScaleX, 10, 10);

        if(Input.GetKey(KeyCode.Space) && isGrounded)
        {
            Jump();
        }

        // Set animator parameters
        anim.SetBool("isRunning", horizontalInput != 0);
        anim.SetBool("isGrounded", isGrounded);
    }

    private void Jump()
    {
        Playerbody.velocity = new Vector2(Playerbody.velocity.x, speed);
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            isGrounded = true;
    }
}
