using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.ActorState.PlayerState
{
    public class PlayerDoubledDMG : AbsActorState
    {
        public PlayerDoubledDMG()
        {
            this.DamageTakenMult = 1.0;
            this.DamageGivenMult = 2.0;
        }

        public override string getState()
        {
            return "Double Damage";
        }
    }
}
