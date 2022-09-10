using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D Playerbody;

    private void Awake()
    {
        Playerbody = GetComponent<Rigidbody2D>();
    }

    //Runs every frame
    private void Update()
    {
        Playerbody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed,Playerbody.velocity.y);

        if(Input.GetKey(KeyCode.Space))
        {
            Playerbody.velocity = new Vector2(Playerbody.velocity.x, speed);
        }
    }
}
