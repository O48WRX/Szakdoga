﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GameBaseClassLibrary.Pickup.Interface
{
    internal interface PickupInterface
    {
        void OnCollisionEnter2D(Collision2D collision);
    }
}
