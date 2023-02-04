using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.ActorState.PlayerState
{
    public class PlayerGodState : AbsActorState
    {
        // Extra easy mode
        public PlayerGodState() 
        {
            this.DamageTakenMult = 0.0;
            this.DamageGivenMult = 100.0;
        }

        public override string getState()
        {
            return "GodMode";
        }
    }
}
