using GameBaseClassLibrary.Camera.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GameBaseClassLibrary.Camera.Abstracts
{
    public abstract class AbstractFollowPlayerCamera : MonoBehaviour, CameraMovementInterface
    {
        [SerializeField] protected Transform player;
        [SerializeField] protected float aheadDistance;
        [SerializeField] protected float cameraSpeed;
        protected float lookAhead;
    }
}
