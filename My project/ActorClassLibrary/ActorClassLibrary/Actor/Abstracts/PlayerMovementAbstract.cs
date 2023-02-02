using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActorClassLibrary.Interfaces;
using UnityEngine;

namespace ActorClassLibrary.Abstracts
{
    public abstract class PlayerMovementAbstract : MonoBehaviour, PlayerMovementInterface
    {
        public float speed = 10;
        public Rigidbody2D Playerbody;
        public Animator anim;

        public float playerScaleX = 10;
        public float negPlayerScaleX = -10;
        public bool isGrounded;
        public float horizontalInput;
        public bool isFalling = false;



        /// <summary>
        /// The player can attack if it isn't moving and is grounded.
        /// </summary>
        /// <returns>
        /// True if the player isn't moving on the X axis and is touching the tagged ground.
        /// False, if the player is moving on the X axis or not grounded.
        /// </returns>
        public bool canAttack()
        {
            return horizontalInput == 0 && isGrounded;
        }

        /// <summary>
        /// Flips the playerbody's transform, based on the input of the player on the X axis.
        /// </summary>
        public void FlipPlayerSpriteTransform()
        {
            if (horizontalInput > 0.01f)
                transform.localScale = new Vector3(playerScaleX, 10, 10);
            else if (horizontalInput < -0.01f)
                transform.localScale = new Vector3(negPlayerScaleX, 10, 10);
        }

        /// <summary>
        /// Sets the Playerbody's velocity to a new vector of (current velocity on X axis, jumpspeed).
        /// Sets isGrounded to false.
        /// </summary>
        public void Jump()
        {
            Playerbody.velocity = new Vector2(Playerbody.velocity.x, speed);
            isGrounded = false;
        }

        /// <summary>
        /// If the input key (W by default) is pressed, and the player is grounded then the player can jump.
        /// Calls the Jump() method.
        /// </summary>
        public abstract void JumpIfCan();
        

        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Ground")
            {
                isGrounded = true;
                Playerbody.velocity = new Vector2(Playerbody.velocity.x, 0);
            }
        }

        /// <summary>
        /// Function that determines whether the Player (Playerbody) is falling or not.
        /// </summary>
        /// <returns>True if the playerbody's velocity on th y axis is less than -0.1, else returns false.</returns>
        public bool isPlayerFalling()
        {
            if (Playerbody.velocity.y < -0.1)
            {
                return true;
            }
            else { return false; }
        }

        /// <summary>
        /// Sets the fall boolean of the class based on the returned value from 'isPlayerFalling()'
        /// </summary>
        public void PlayerSetFallBoolean()
        {
            if (isPlayerFalling())
            {
                isFalling = true;
            }
            else { isFalling = false; }
        }
    }
}
