using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.ActorState.EnemyState
{
    public class EnemyDefaultState : AbsActorState
    {
        public EnemyDefaultState() {
            this.DamageGivenMult = 1.0;
            this.DamageTakenMult = 1.0;
        }
        public override string getState()
        {
            return "default";
        }
    }
}
