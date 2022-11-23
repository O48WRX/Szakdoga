using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ActorClassLibrary.Interfaces
{
    internal interface PlayerMovementInterface
    {
        void FlipPlayerSpriteTransform();
        void JumpIfCan();
        void Jump();
        void OnCollisionEnter2D(Collision2D collision);
        bool canAttack();
        bool isPlayerFalling();
        void PlayerSetFallBoolean();
    }
}
