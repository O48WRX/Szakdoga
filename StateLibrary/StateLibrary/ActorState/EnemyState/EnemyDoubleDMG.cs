using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.ActorState.EnemyState
{
    public class EnemyDoubleDMG : AbsActorState
    {

        public EnemyDoubleDMG() {
            this.DamageGivenMult = 2.0;
            this.DamageTakenMult = 1.0;
        } 
        public override string getState()
        {
            return "Double Damage";
        }
    }
}
