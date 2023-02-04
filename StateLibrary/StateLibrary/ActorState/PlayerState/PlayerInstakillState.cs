using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.ActorState.PlayerState
{
    public class PlayerInstakillState : AbsActorState
    {
        public PlayerInstakillState() 
        {
            this.DamageTakenMult = 1.0;
            this.DamageGivenMult = 100.0;
        }

        public override string getState()
        {
            return "Instakill";
        }
    }
}
