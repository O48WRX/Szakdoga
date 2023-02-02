using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GameBaseClassLibrary.Camera.Abstracts
{
    public abstract class AbstractRoomCamera
    {
        [SerializeField] protected float speed;
        protected float currentPosX;
        protected Vector3 velocity = Vector3.zero;
    }
}
