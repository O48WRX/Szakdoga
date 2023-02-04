using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.ActorState.PlayerState
{
    public class PlayerDoubledDT : AbsActorState
    {
        public PlayerDoubledDT()
        {
            this.DamageGivenMult = 1.0;
            this.DamageTakenMult = 2.0;
        }

        public override string getState()
        {
            return "Doubled Damage Taken";
        }
    }
}
