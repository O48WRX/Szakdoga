using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.ActorState.EnemyState
{
    public class EnemyDoubledDT : AbsActorState
    {
        public EnemyDoubledDT()
        {
            this.DamageGivenMult = 1.0;
            this.DamageTakenMult = 2.0;
        }
        public override string getState()
        {
            return "Double Damage Taken";
        }
    }
}
