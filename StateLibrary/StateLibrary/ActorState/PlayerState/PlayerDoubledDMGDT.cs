using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.ActorState.PlayerState
{
    public class PlayerDoubledDMGDT : AbsActorState
    {
        public PlayerDoubledDMGDT() 
        {
            this.DamageGivenMult = 2.0;
            this.DamageTakenMult = 2.0;
        }

        public override string getState()
        {
            return "Damage given and taken doubled";
        }
    }
}
