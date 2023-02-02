using GameBaseClassLibrary.Actor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorClassLibrary.Interfaces
{
    internal interface PlayerAttackInterface : AttackInterface
    {
        void OnDrawGizmosSelected();
    }
}
