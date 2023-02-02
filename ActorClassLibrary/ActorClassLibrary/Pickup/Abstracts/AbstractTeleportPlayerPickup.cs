using GameBaseClassLibrary.Pickup.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GameBaseClassLibrary.Pickup.Abstracts
{
    public abstract class AbstractTeleportPlayerPickup : MonoBehaviour, PickupInterface
    {
        public Transform playerTransform;

        public Transform TeleportLocation;
        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                playerTransform.position = TeleportLocation.position;
            }
        }
    }
}
