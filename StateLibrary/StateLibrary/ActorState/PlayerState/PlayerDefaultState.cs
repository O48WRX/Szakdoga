using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.ActorState.PlayerState
{
    public class PlayerDefaultState : AbsActorState
    {
        public PlayerDefaultState()
        {
            this.DamageGivenMult = 1.0;
            this.DamageTakenMult = 1.0;
        }
        public override string getState()
        {
            return "Default";
        }
    }
}
